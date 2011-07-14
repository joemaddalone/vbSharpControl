Option Strict On
Imports System.Xml
Imports System.Net
Partial Public Class read

  ''' <summary>
  ''' Returns xml from http source as datatable
  ''' </summary>
  ''' <param name="url">The URL.</param>
  ''' <param name="rootEl">The root el.</param>
  ''' <param name="limit">The limit.</param><returns></returns>
  Shared Function xml(ByVal url As String,
                      ByVal rootEl As String,
                      Optional ByVal limit As Integer = 0, Optional isLocal As Boolean = False) As System.Data.DataTable
    Dim xd As New XmlDocument()
    If Not isLocal Then
      If isResponsive(url, 5000) Then
        xd.Load(System.Net.WebRequest.Create(url).GetResponse.GetResponseStream())
        Return xml(xd, rootEl, limit)
      Else
        Return New Data.DataTable
      End If
    Else
      xd.Load(url)
      Return xml(xd, rootEl, limit)
    End If

  End Function


  ''' <summary>
  ''' Returns xml from local or localized source as datatable
  ''' </summary>
  ''' <param name="xd">The XML Document.</param>
  ''' <param name="rootEl">The root element.</param>
  ''' <param name="limit">The limit.</param><returns></returns>
  Shared Function xml(ByVal xd As XmlDocument,
                       ByVal rootEl As String,
                       Optional ByVal limit As Integer = 0) As System.Data.DataTable

    Dim xn As XmlNodeList = xd.GetElementsByTagName(rootEl)
    Using recs As New DataTable()
      Dim r As Integer = xn(0).ChildNodes.Count - 1
      For i As Integer = 0 To r
        If xn(0).ChildNodes(i).Attributes.Count > 0 Then
          recs.Columns.Add(xn(0).ChildNodes(i).LocalName.Replace("-", "_") & "_" &
                           xn(0).ChildNodes(i).Attributes(0).Value)
        Else
          recs.Columns.Add(xn(0).ChildNodes(i).LocalName.Replace("-", "_"))
        End If
      Next
      Dim row As DataRow
      For i = 0 To If(limit = 0, xn.Count - 1, limit)
        row = recs.NewRow()
        For x = 0 To r
          row(x) = __(xn(i).ChildNodes.Item(x).InnerText)
        Next
        recs.Rows.Add(row)
      Next
      Return recs
    End Using
  End Function
End Class
