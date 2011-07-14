Imports System.Runtime.CompilerServices
Public Module advMath

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function IsPrime(ByVal x As Long) As Boolean
    If x = 1 Then Return False
    If x < 4 Then Return True
    If x.even Then Return False
    If x < 9 Then Return True
    If x.divBy(3) Then Return False
    Dim r As Integer = CInt(Math.Floor(Math.Sqrt(x)))
    Dim f As Integer = 5
    Do While r <= f
      If x.divBy(f) Then Return False
      If x.divBy(f + 2) Then Return False
      f += 6
    Loop
    Return True
  End Function

  ''' <summary>
  ''' Sieve of Eratosthenes
  ''' </summary>
  ''' <param name="limit"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function sieve(ByVal limit As Integer) As Boolean()
    Dim sievebound As Integer = CInt((limit - 1) / 2)
    Dim crosslimit As Integer = CInt((Math.Sqrt(limit) - 1) / 2)
    Dim s(limit) As Boolean
    For x As Integer = 1 To crosslimit
      If Not s(x) Then
        For y As Integer = 2 * x * (x + 1) To sievebound Step 2 * x + 1
          s(y) = True
        Next
      End If
    Next
    Return s
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="l"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function alphaPos(ByVal l As String) As Integer
    Dim a As String = "abcdefghijklmnopqrstuvwxyz"
    Return a.IndexOf(l) + 1
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function isPalindrome(ByVal x As Integer) As Boolean
    Return CStr(x) = StrReverse(CStr(x))
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function isTriangle(ByVal x As Long) As Boolean
    Dim n As Integer = CType((Math.Sqrt((8 * x) + 1) - 1) / 2, Integer)
    If n - CInt(x) > 0 Then
      Return False
    Else
      Return True
    End If
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function factorial(ByVal x As Long) As Long
    Dim ret As Long = 1
    For i As Integer = CInt(x) To 2 Step -1
      ret *= i
    Next
    Return ret
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function factorialSum(ByVal x As Long) As Long
    Return CLng(x * (x + 1) / 2)
  End Function


  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function addSquares(ByVal x As Long) As Long
    Dim ret As Long = 0
    For i As Integer = 1 To CInt(x)
      ret += CLng(i ^ 2)
    Next
    Return ret
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="n"></param>
  ''' <param name="target"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function SumDivisibleBy(ByVal n As Long, ByVal target As Long) As Long
    Dim p As Long = target \ n
    Return n * (p * (p + 1)) \ 2
  End Function


  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function divisors(ByVal x As Long) As List(Of Long)
    Dim f As New List(Of Long)
    Dim nearest_sq As Integer = CInt(Math.Sqrt(CDbl(x)))
    For i As Integer = 1 To CInt(nearest_sq)
      If x.divBy(i) Then
        f.Add(i)
      End If
    Next
    Dim y As Integer = f.Count - 1
    For i = 0 To y
      If x / f(i) <> f(i) Then
        f.Add(CLng(x / f(i)))
      End If
    Next
    f.Sort()
    Return f
  End Function



  ''' <summary>
  ''' list each integer in a number
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function digitInteger(ByVal x As Integer) As List(Of Integer)
    Dim f As New List(Of Integer)
    For i As Integer = 0 To x.ToString.Length - 1
      f.Add(CType(x.ToString.Substring(i, 1), Integer))
    Next
    Return f
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <param name="max"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function listAdd(ByVal x As List(Of Long), Optional ByVal max As Integer = 0) As Long
    Dim ret As Long = 0
    Dim dbug As String = ""
    For i As Integer = 0 To x.Count - (1 + max)
      'dbug &= x(i).ToString & "+"
      ret += x(i)
    Next
    'Console.WriteLine(dbug)

    Return ret
  End Function


  ''' <summary>
  ''' Fibonacci to x
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function Fibonacci(ByVal x As Long) As Long
    Dim previousValue As Integer = -1
    Dim currentResult As Integer = 1
    Dim sum As Integer
    For i = 0 To x
      sum = currentResult + previousValue
      previousValue = currentResult
      currentResult = sum
    Next
    Return currentResult
  End Function

  ''' <summary>
  ''' Collatz Conjecture
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function collatz(ByVal x As Long) As Long
    Dim steps As Integer = 0
    While x > 1
      If x.even Then
        x = CLng(x / 2)
      Else
        x = (3 * x) + 1
      End If
      steps += 1

    End While
    Return steps + 1
  End Function

  ''' <summary>
  ''' binominal coefficient
  ''' </summary>
  ''' <param name="m"></param>
  ''' <param name="n"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function binominal_coefficient(ByVal m As Long, ByVal n As Long) As Long
    Return CLng(factorial(m + n) / (factorial(m) * factorial(n)))
  End Function


  ''' <summary>
  ''' even int
  ''' </summary>
  ''' <param name="val"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function even(ByVal val As Integer) As Boolean
    Return val Mod 2 = 0
  End Function

  ''' <summary>
  ''' even long
  ''' </summary>
  ''' <param name="val"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function even(ByVal val As Long) As Boolean
    Return val Mod 2 = 0
  End Function

  ''' <summary>
  ''' mod ints
  ''' </summary>
  ''' <param name="val"></param>
  ''' <param name="div"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function divBy(ByVal val As Integer, ByVal div As Integer) As Boolean
    Return val Mod div = 0
  End Function

  ''' <summary>
  ''' mod longs
  ''' </summary>
  ''' <param name="val"></param>
  ''' <param name="div"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function divBy(ByVal val As Long, ByVal div As Long) As Boolean
    Return val Mod div = 0
  End Function

  ''' <summary>
  ''' convert number to words
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function convertToWords(ByVal x As Integer) As String
    Dim toNineteen As New List(Of String)
    With toNineteen
      .Add("")
      .Add("one")
      .Add("two")
      .Add("three")
      .Add("four")
      .Add("five")
      .Add("six")
      .Add("seven")
      .Add("eight")
      .Add("nine")
      .Add("ten")
      .Add("eleven")
      .Add("twelve")
      .Add("thirteen")
      .Add("fourteen")
      .Add("fifteen")
      .Add("sixteen")
      .Add("seventeen")
      .Add("eighteen")
      .Add("nineteen")
    End With
    Dim tens As New List(Of String)
    With tens
      .Add("")
      .Add("")
      .Add("twenty")
      .Add("thirty")
      .Add("forty")
      .Add("fifty")
      .Add("sixty")
      .Add("seventy")
      .Add("eighty")
      .Add("ninety")
    End With
    Select Case x
      Case Is < 20 : Return toNineteen(x)
      Case 20 To 99 : Return tens(CInt(x \ 10)) & " " & convertToWords(x Mod 10)
      Case 100 To 999 : Return toNineteen(CInt(x \ 100)) & " hundred " & convertToWords(x Mod 100)
      Case Else
        Return ""
    End Select
  End Function
End Module
