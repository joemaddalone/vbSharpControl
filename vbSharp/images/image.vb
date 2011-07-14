Option Explicit On
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO



Public Class images

  Private Shared Function getFont() As Font
    Using this As New Font("tahoma", 20, FontStyle.Bold)
      Return this
    End Using
  End Function

  Private Shared Function getShadow() As SolidBrush
    Using this As New SolidBrush(Color.FromArgb(50, 0, 0, 0))
      Return this
    End Using
  End Function

  Private Shared Function getLetterBrush() As SolidBrush
    Using this As New SolidBrush(Color.FromArgb(50, 255, 255, 255))
      Return this
    End Using
  End Function


  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="filename"></param>
  ''' <param name="str"></param>
  ''' <param name="saveAs"></param>
  ''' <remarks></remarks>
  Public Shared Sub watermark(ByVal filename As String, ByVal str As String, ByVal saveAs As String)
    Dim Width, Height As Integer
    Dim ImgFormat As Imaging.ImageFormat
    Dim Img As System.Drawing.Image
    ImgFormat = Imaging.ImageFormat.Jpeg
    Img = System.Drawing.Image.FromFile(filename)
    Width = Img.Width
    Height = Img.Height
    Img.Dispose()

    Using baseMap As New Bitmap(Width, Height)
      Dim myGraphic As Graphics = Graphics.FromImage(baseMap)
      With myGraphic
        .DrawImage(Img, 0, 0, Width, Height)
        .SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        .DrawString(str, getFont, getShadow, 5, 60)
        .DrawString(str, getFont, getLetterBrush, 7, 62)
      End With
      'letterBrush.Dispose()
      'shadowBrush.Dispose()
      'fontTitle.Dispose()
      baseMap.Save(saveAs, Imaging.ImageFormat.Jpeg)
    End Using

  End Sub

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="filename"></param>
  ''' <param name="shiftTo"></param>
  ''' <param name="saveAs"></param>
  ''' <remarks></remarks>
  Public Shared Sub colorShift(ByVal filename As String, ByVal shiftTo As Integer, ByVal saveAs As String)

    Dim x, y, h, w, l As Integer
    Dim ImgFormat As Imaging.ImageFormat
    ImgFormat = Imaging.ImageFormat.Jpeg
    Dim Img As System.Drawing.Bitmap = CType(System.Drawing.Bitmap.FromFile(filename), Bitmap)

    h = Img.Height
    w = Img.Width
    For y = 0 To h - 1
      For x = 0 To w - 1
        Dim c As Color = Img.GetPixel(x, y)
        l = CInt(c.R * 0.3 + c.G * 0.59 + c.B * 0.11)
        Select Case shiftTo
          Case 0 'grayscale
            Img.SetPixel(x, y, Color.FromArgb(l, l, l))
          Case 1 'red
            Img.SetPixel(x, y, Color.FromArgb(l, 0, 0))
          Case 2 'green
            Img.SetPixel(x, y, Color.FromArgb(0, l, 0))
          Case 3 'blue
            Img.SetPixel(x, y, Color.FromArgb(0, 0, l))
          Case 4 'purple
            Img.SetPixel(x, y, Color.FromArgb(l, 0, l))
          Case 5 'tellow
            Img.SetPixel(x, y, Color.FromArgb(l, l, 0))
          Case 6 'blue-green
            Img.SetPixel(x, y, Color.FromArgb(0, l, l))
        End Select
      Next
    Next


    Img.Save(saveAs, Imaging.ImageFormat.Jpeg)
    Img.Dispose()



  End Sub




End Class
