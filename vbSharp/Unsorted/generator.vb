Class RandomStringGenerator
  Property ret As String = ""
  Sub New(x As Integer)
    ret = ""
    ret = go(x)

  End Sub
  Function go(ByVal intLen As Integer) As String
    Dim rRandom As New Random(GetNewSeed)
    rRandom.Next()

    Dim Zero As Integer = Asc("0")
    Dim Nine As Integer = Asc("9")
    Dim capA As Integer = Asc("A")
    Dim capZ As Integer = Asc("Z")
    Dim litA As Integer = Asc("a")
    Dim litZ As Integer = Asc("z")

    Dim iRandNum As Integer
    Dim strTemp As String = ""
    Dim i As Integer
    While i < intLen
      iRandNum = rRandom.Next(Zero, litZ)
      If ((((iRandNum >= Zero) And (iRandNum <= Nine) Or _
      (iRandNum >= capA) And (iRandNum <= capZ) Or _
      (iRandNum >= litA) And (iRandNum <= litZ)))) Then
        strTemp = strTemp + Chr(iRandNum)
        i += 1
      End If
    End While
    Return strTemp
  End Function

  Function GetNewSeed() As Integer
    Dim arrBytes As Byte() = Guid.NewGuid().ToByteArray()  '16 bytes
    Dim seedNum As Integer = 0
    ' Boil GUID down 4 bytes at a time (size of int) and merge into Integer value
    For i As Integer = 0 To arrBytes.Length - 1 Step 4
      seedNum = seedNum Xor BitConverter.ToInt32(arrBytes, i)
    Next
    Return seedNum
  End Function

End Class