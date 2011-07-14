Option Strict On
Imports System.Xml
Imports System.Net
Partial Public Class read
  
  ''' <summary>
  ''' RSS as datatable.
  ''' </summary>
  ''' <param name="url">The URL of the RSS feed.</param>
  ''' <param name="fields">The fields of the RSS field to include in the Satatable</param>
  ''' <param name="limit">Limits the number of returned records, 0=ALL</param><returns></returns>
  Public Shared Function rss(ByVal url As String,
                              ByVal fields As String(),
                              Optional ByVal limit As Integer = 0) As DataTable
    If isResponsive(url) Then
      Dim document As New XmlDocument
      document.Load(WebRequest.Create(url).GetResponse.GetResponseStream)
      Dim list As XmlNodeList = document.SelectNodes("rss/channel/item")
      Using recs As DataTable = New DataTable
        Dim str As String
        For Each str In fields
          recs.Columns.Add(str)
        Next
        Dim num3 As Integer = If((limit = 0), (list.Count - 1), limit)
        Dim i As Integer = 0
        Do While (i <= num3)
          Dim row As DataRow = recs.NewRow
          Dim str2 As String
          For Each str2 In fields
            row.Item(str2) = list.Item(i).SelectSingleNode(str2).InnerText
          Next
          recs.Rows.Add(row)
          i += 1
        Loop
        Return recs
      End Using
    End If
    Return New DataTable
  End Function
End Class
