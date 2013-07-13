Option Strict On
Imports System.Net
Imports System.Threading
Imports System.IO
Imports System.Web.UI
Imports System.Text
Imports System.Web
''' <summary>
''' Common Functionality
''' </summary>
''' <remarks></remarks>
Public Module common
  ''' <summary>
  ''' A quick way to access httpcontext.content
  ''' </summary>
  ''' <returns>System.Web.HttpContext.Current</returns>
  ''' <remarks></remarks>
  Function PG() As HttpContext
    Return System.Web.HttpContext.Current
  End Function


    Public PathOf As Func(Of String, String) = Function(s) PhysicalPath() & s
    Public PhysicalPath As Func(Of String) = Function() PG.Request.PhysicalApplicationPath
    Public AP As Func(Of String, String) =
      Function(s) System.Configuration.ConfigurationManager.AppSettings(s)
    Public Nav As Action(Of String) = Sub(url) PG.Response.Redirect(url)
    Public NavBack As Action = Sub() Nav(PG.Request.UrlReferrer.ToString)
    Public rW As Action(Of String) = Sub(s) PG.Response.Write(s)
    Public rCook As Action(Of String, String) =
        Sub(name, val)
            Dim cookie As HttpCookie = PG.Request.Cookies.Get(name)
            If (cookie Is Nothing) Then
                cookie = New HttpCookie(name)
            Else
                PG.Response.Cookies.Remove(name)
                cookie = New HttpCookie(name)
            End If
            cookie.Value = val
            PG.Response.Cookies.Add(cookie)
        End Sub
    Public rSession As Action(Of String, String) = Sub(s, s2) PG.Session(s) = s2
    Public rqQ As Func(Of String, String) = Function(s) PG.Request.QueryString(s)
    Public rqF As Func(Of String, String) = Function(s) PG.Request.Form(s)
    Public rqCook As Func(Of String, String) = Function(s) PG.Request.Cookies(s).Value

  Public Function timestamp() As String
    Return Now.ToString.mReplace({":", "/", "-", " ", "."})
  End Function
  
  

  Public Function isResponsive(ByVal url As String,
                               Optional ByVal timed As Integer = 0) As Boolean
    Try

      Dim res As WebResponse = Nothing
      Dim WebReq As HttpWebRequest = CType(HttpWebRequest.Create(url), HttpWebRequest)
      If timed > 0 Then
        WebReq.Timeout = timed
      End If
      res = WebReq.GetResponse
      res.Close()
      Return True
    Catch ex0 As TimeoutException
      Return False
    Catch ex1 As WebException
      Return False
    Catch ex As Exception
      Return False
    End Try
  End Function


End Module