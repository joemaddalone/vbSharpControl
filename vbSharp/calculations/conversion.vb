Public Class conversion
  Shared Function deg2rad(ByVal deg As Double) As Double
    Return (deg * Math.PI / 180.0)
  End Function

  Shared Function rad2deg(ByVal rad As Double) As Double
    Return rad / Math.PI * 180.0
  End Function
End Class
