Imports System.Text

Public Class google

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="address"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Shared Function map(ByVal address As String) As String
    Dim recs As Data.DataTable
    Dim ret As New StringBuilder
    Dim html As String
    Dim coordinates As String()
    Dim lat As String
    Dim lon As String

    recs = read.xml("http://maps.google.com/maps/geo?output=xml&key=123123&q=" & address, "Point")
    If hasrecs(recs) Then
      coordinates = __(recs.Rows(0)(0)).Split(CChar(","))
      lat = coordinates(1)
      lon = coordinates(0)
      With ret
        .Append("<script src=""http://maps.google.com/maps/api/js?sensor=false"" type=""text/javascript""></script>")
        .Append("<script type=""text/javascript"">" & vbCrLf & vbCrLf)
        .Append("$(document).ready(function(){" & vbCrLf & vbCrLf)
        .Append("var marker;" & vbCrLf & vbCrLf)
        .Append("var infowindow;" & vbCrLf & vbCrLf)
        .Append("var lbl;" & vbCrLf & vbCrLf)
        .Append("var thisLL0;" & vbCrLf & vbCrLf)
        .Append("var connect = [];" & vbCrLf & vbCrLf)
        .Append("var centerLL = new google.maps.LatLng(" & lon & "," & lat & ");" & vbCrLf & vbCrLf)
        .Append("var myOptions = {")
        .Append("zoom: 8,")
        .Append("center: centerLL,")
        .Append("mapTypeId: google.maps.MapTypeId.ROADMAP")
        .Append("};" & vbCrLf & vbCrLf)
        .Append("var map = new google.maps.Map($('#map_canvas').get(0), myOptions);" & vbCrLf & vbCrLf)
        '.Append("map.setCenter(centerLL, 7);" & vbCrLf & vbCrLf)
        '.Append("map.setUIToDefault();" & vbCrLf & vbCrLf)
        html = address
        Dim i As String = "0"
        .Append("var thisLL" & i & " = new google.maps.LatLng(" & lon & "," & lat & ");" & vbCrLf & vbCrLf)
        .Append("var marker" & i & " = new google.maps.Marker({ position: thisLL" & i & "});" & vbCrLf & vbCrLf)
        .Append("var infowindow" & i & " = new google.maps.InfoWindow({ content: """ & html & """  });" & vbCrLf & vbCrLf)
        .Append("google.maps.event.addListener(marker" & i & ", 'click', function () { infowindow" & i & ".open(map, marker" & i & "); });" & vbCrLf & vbCrLf)
        .Append("marker" & i & ".setMap(map);" & vbCrLf & vbCrLf)
        '.Append("connect.push(thisLL" & i & ");" & vbCrLf & vbCrLf & vbCrLf)
        .Append("function createMarker(point,html) {" & vbCrLf & vbCrLf)
        .Append("var marker = new GMarker(point,1);" & vbCrLf & vbCrLf)
        .Append("GEvent.addListener(marker, 'click', function() {marker.openInfoWindowHtml(html);});" & vbCrLf & vbCrLf)
        .Append("return marker;" & vbCrLf & vbCrLf)
        .Append("}})")
        .Append("</script>")
      End With
    Else
      ret.Append("notta")
    End If

    Return ret.ToString
  End Function




End Class



