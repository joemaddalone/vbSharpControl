Public Class commonData

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function countries() As List(Of String)
    Dim this As New List(Of String)
    With this
      .Add("")
      .Add("United States")
      .Add("Andorra")
      .Add("United Arab Emirates")
      .Add("Afghanistan")
      .Add("Antigua & Barbuda")
      .Add("Anguilla")
      .Add("Albania")
      .Add("Armenia")
      .Add("Netherlands Antilles")
      .Add("Angola")
      .Add("Antarctica")
      .Add("Argentina")
      .Add("American Samoa")
      .Add("Austria")
      .Add("Australia")
      .Add("Aruba")
      .Add("Azerbaijan")
      .Add("Bosnia-Hercegovina")
      .Add("Barbados")
      .Add("Bangladesh")
      .Add("Belgium")
      .Add("Burkina Faso")
      .Add("Bulgaria")
      .Add("Bahrain")
      .Add("Burundi")
      .Add("Benin")
      .Add("Bermuda")
      .Add("Brunei")
      .Add("Bolivia")
      .Add("Brazil")
      .Add("Bahamas")
      .Add("Bhutan")
      .Add("Bouvet Island")
      .Add("Botswana")
      .Add("Belarus")
      .Add("Belize")
      .Add("Canada")
      .Add("Cocos (Keeling) Islands")
      .Add("Congo")
      .Add("The Democratic Republic Of T")
      .Add("Central African Republic")
      .Add("Congo")
      .Add("Switzerland")
      .Add("Ivory Coast")
      .Add("Cook Islands")
      .Add("Chile")
      .Add("Cameroon")
      .Add("China (Mainland)")
      .Add("Colombia")
      .Add("Costa Rica")
      .Add("Cuba")
      .Add("Cape Verde")
      .Add("Christmas Island(Indian Ocean)")
      .Add("Cyprus")
      .Add("Czech Republic")
      .Add("Germany")
      .Add("Djibouti")
      .Add("Denmark")
      .Add("Dominica")
      .Add("Dominican Republic")
      .Add("Algeria")
      .Add("Ecuador")
      .Add("Estonia")
      .Add("Egypt")
      .Add("Western Sahara")
      .Add("Eritrea")
      .Add("Spain")
      .Add("Ethiopia")
      .Add("Finland")
      .Add("Fiji")
      .Add("Falkland Islands")
      .Add("Micronesia")
      .Add("Faroe Islands")
      .Add("France")
      .Add("France")
      .Add("Gabon")
      .Add("United Kingdom")
      .Add("Grenada")
      .Add("Georgia")
      .Add("French Guiana")
      .Add("Ghana")
      .Add("Gibraltar")
      .Add("Greenland")
      .Add("The Gambia")
      .Add("Guinea")
      .Add("Guadeloupe")
      .Add("Equatorial Guinea")
      .Add("Greece")
      .Add("South Georgia And The South Sandwic")
      .Add("Guatemala")
      .Add("Guam")
      .Add("Guinea-Bissau")
      .Add("Guyana")
      .Add("Gaza Strip")
      .Add("Hong Kong")
      .Add("Heard And Mcdonald Islands")
      .Add("Honduras")
      .Add("Croatia")
      .Add("Haiti")
      .Add("Hungary")
      .Add("Indonesia")
      .Add("Ireland")
      .Add("Israel")
      .Add("India")
      .Add("British Indian Ocean Territory")
      .Add("Iraq")
      .Add("Iran")
      .Add("Iceland")
      .Add("Italy")
      .Add("Jamaica")
      .Add("Jordan")
      .Add("Japan")
      .Add("Kenya")
      .Add("Kyrgyzstan")
      .Add("Cambodia")
      .Add("Kiribati")
      .Add("Comoros")
      .Add("St. Christopher-Nevis")
      .Add("North Korea")
      .Add("South Korea")
      .Add("Kuwait")
      .Add("Cayman Islands")
      .Add("Kazakhstan")
      .Add("Laos")
      .Add("Lebanon")
      .Add("St. Lucia")
      .Add("Liechtenstein")
      .Add("Sri Lanka")
      .Add("Liberia")
      .Add("Lesotho")
      .Add("Lithuania")
      .Add("Luxembourg")
      .Add("Latvia")
      .Add("Libya")
      .Add("Morocco")
      .Add("Monaco")
      .Add("Moldova")
      .Add("Madagascar (Malagasy)")
      .Add("Marshall Islands")
      .Add("Macedonia (Skopje)")
      .Add("Mali")
      .Add("Myanmar (Burma)")
      .Add("Mongolia")
      .Add("Macao (Macau)")
      .Add("Northern Mariana Islands")
      .Add("Martinique")
      .Add("Mauritania")
      .Add("Montserrat")
      .Add("Malta And Gozo")
      .Add("Mauritius")
      .Add("Maldives")
      .Add("Malawi")
      .Add("Mexico")
      .Add("Malaysia")
      .Add("Mozambique")
      .Add("Namibia")
      .Add("New Caledonia")
      .Add("Niger")
      .Add("Norfolk Island")
      .Add("Nigeria")
      .Add("Nicaragua")
      .Add("Netherlands")
      .Add("Norway")
      .Add("Nepal")
      .Add("Nauru")
      .Add("Niue")
      .Add("New Zealand")
      .Add("Oman")
      .Add("Panama")
      .Add("Peru")
      .Add("French Polynesia")
      .Add("Papua New Guinea")
      .Add("Philippines")
      .Add("Pakistan")
      .Add("Poland")
      .Add("St Pierre And Miquelon")
      .Add("Pitcairn Island")
      .Add("Puerto Rico")
      .Add("Palestinian Territory")
      .Add("Portugal")
      .Add("Palau")
      .Add("Paraguay")
      .Add("Qatar")
      .Add("Romania")
      .Add("Russia")
      .Add("Rwanda")
      .Add("Saudi Arabia")
      .Add("Solomon Islands")
      .Add("Seychelles")
      .Add("Sudan")
      .Add("Sweden")
      .Add("Singapore")
      .Add("St Helena")
      .Add("Slovenia")
      .Add("Svalbard And Jan Mayen Island")
      .Add("Slovakia")
      .Add("Sierra Leone")
      .Add("San Marino")
      .Add("Senegal")
      .Add("Somalia")
      .Add("Suriname")
      .Add("Sao Tome And Principe")
      .Add("El Salvador")
      .Add("Syria")
      .Add("Swaziland")
      .Add("Turks And Caicos Islands")
      .Add("Chad")
      .Add("Fr Southern & Antarctic Lands")
      .Add("Togo")
      .Add("Thailand")
      .Add("Tajikistan")
      .Add("Tokelau Islands")
      .Add("Turkmenistan")
      .Add("Tunisia")
      .Add("Tonga")
      .Add("East Timor")
      .Add("Turkey")
      .Add("Trinidad And Tobago")
      .Add("Tuvalu")
      .Add("China (Taiwan)")
      .Add("Tanzania")
      .Add("Ukraine")
      .Add("Uganda")
      .Add("United States Minor Outlying Island")
      .Add("United States")
      .Add("Uruguay")
      .Add("Uzbekistan")
      .Add("Vatican City")
      .Add("St. Vincent And The Grenadine")
      .Add("Venezuela")
      .Add("British Virgin Islands")
      .Add("Virgin Island Of The Us")
      .Add("Vietnam")
      .Add("Vanuatu")
      .Add("West Bank")
      .Add("Wallis And Futuna")
      .Add("Western Samoa")
      .Add("Yemen (Sana)")
      .Add("Mayotte")
      .Add("Yugoslavia")
      .Add("Republic Of South Africa")
      .Add("Zambia")
      .Add("Zaire")
      .Add("Zimbabwe")
    End With
    Return this
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function usStates() As List(Of usState)
    Dim this As New List(Of usState)
    With this
      .Add(New usState("", ""))
      .Add(New usState("Alabama", "AL"))
      .Add(New usState("Alaska", "AK"))
      .Add(New usState("Arizona", "AZ"))
      .Add(New usState("Arkansas", "AR"))
      .Add(New usState("California", "CA"))
      .Add(New usState("Colorado", "CO"))
      .Add(New usState("Connecticut", "CT"))
      .Add(New usState("District of Columbia", "DC"))
      .Add(New usState("Delaware", "DE"))
      .Add(New usState("Florida", "FL"))
      .Add(New usState("Georgia", "GA"))
      .Add(New usState("Hawaii", "HI"))
      .Add(New usState("Idaho", "ID"))
      .Add(New usState("Illinois", "IL"))
      .Add(New usState("Indiana", "IN"))
      .Add(New usState("Iowa", "IA"))
      .Add(New usState("Kansas", "KS"))
      .Add(New usState("Kentucky", "KY"))
      .Add(New usState("Louisiana", "LA"))
      .Add(New usState("Maine", "ME"))
      .Add(New usState("Maryland", "MD"))
      .Add(New usState("Massachusetts", "MA"))
      .Add(New usState("Michigan", "MI"))
      .Add(New usState("Minnesota", "MN"))
      .Add(New usState("Mississippi", "MS"))
      .Add(New usState("Missouri", "MO"))
      .Add(New usState("Montana", "MT"))
      .Add(New usState("Nebraska", "NE"))
      .Add(New usState("Nevada", "NV"))
      .Add(New usState("New Hampshire", "NH"))
      .Add(New usState("New Jersey", "NJ"))
      .Add(New usState("New Mexico", "NM"))
      .Add(New usState("New York", "NY"))
      .Add(New usState("North Carolina", "NC"))
      .Add(New usState("North Dakota", "ND"))
      .Add(New usState("Ohio", "OH"))
      .Add(New usState("Oklahoma", "OK"))
      .Add(New usState("Oregon", "OR"))
      .Add(New usState("Pennsylvania", "PA"))
      .Add(New usState("Rhode Island", "RI"))
      .Add(New usState("South Carolina", "SC"))
      .Add(New usState("South Dakota", "SD"))
      .Add(New usState("Tennessee", "TN"))
      .Add(New usState("Texas", "TX"))
      .Add(New usState("Utah", "UT"))
      .Add(New usState("Vermont", "VT"))
      .Add(New usState("Virginia", "VA"))
      .Add(New usState("Washington", "WA"))
      .Add(New usState("West Virginia", "WV"))
      .Add(New usState("Wisconsin", "WI"))
      .Add(New usState("Wyoming", "WY"))
      .Add(New usState("Alberta", "AB"))
      .Add(New usState("British Columbia", "BC"))
      .Add(New usState("Manitoba", "MB"))
      .Add(New usState("New Brunswick", "NB"))
      .Add(New usState("Newfoundland and Labrador", "NL"))
      .Add(New usState("Northwest Territories", "NT"))
      .Add(New usState("Nova Scotia", "NS"))
      .Add(New usState("Nunavut", "NU"))
      .Add(New usState("Ontario", "ON"))
      .Add(New usState("Prince Edward Island", "PE"))
      .Add(New usState("Quebec", "QC"))
      .Add(New usState("Saskatchewan", "SK"))
      .Add(New usState("Yukon", "YT"))
    End With
    Dim Sorter As New Utility.Sorter(Of usState)
    Sorter.SortString = "fullName"
    this.Sort(Sorter)
    Return this
  End Function
 

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function canadaProvince() As List(Of usState)
    Dim this As New List(Of usState)
    With this
      .Add(New usState("Alberta", "AB"))
      .Add(New usState("British Columbia", "BC"))
      .Add(New usState("Manitoba", "MB"))
      .Add(New usState("New Brunswick", "NB"))
      .Add(New usState("Newfoundland and Labrador", "NL"))
      .Add(New usState("Northwest Territories", "NT"))
      .Add(New usState("Nova Scotia", "NS"))
      .Add(New usState("Nunavut", "NU"))
      .Add(New usState("Ontario", "ON"))
      .Add(New usState("Prince Edward Island", "PE"))
      .Add(New usState("Quebec", "QC"))
      .Add(New usState("Saskatchewan", "SK"))
      .Add(New usState("Yukon", "YT"))
    End With
    Return this
  End Function


  ''' <summary>
  ''' 
  ''' </summary>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function months() As List(Of month)
    Dim this As New List(Of month)
    With this
      .Add(New month("January (01)", "01", "Jan"))
      .Add(New month("February (02)", "02", "Feb"))
      .Add(New month("March (03)", "03", "Mar"))
      .Add(New month("April (04)", "04", "Apr"))
      .Add(New month("May (05)", "05", "May"))
      .Add(New month("June (06)", "06", "Jun"))
      .Add(New month("July (07)", "07", "Jul"))
      .Add(New month("August (08)", "08", "Aug"))
      .Add(New month("September (09)", "09", "Sep"))
      .Add(New month("October (10)", "10", "Oct"))
      .Add(New month("November (11)", "11", "Nov"))
      .Add(New month("December(12)", "12", "Dec"))
    End With
    Return this
  End Function



End Class


Public Class usState
 

  Property fullName As String
  Property abbreviatedName As String
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="full"></param>
  ''' <param name="abbreviation"></param>
  ''' <remarks></remarks>
  Sub New(full As String, abbreviation As String)
    fullName = full
    abbreviatedName = abbreviation
  End Sub

End Class



Public Class month
  Property fullName As String
  Property abbreviatedName As String
  Property abbreviatedTxt As String
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="full"></param>
  ''' <param name="abbreviation"></param>
  ''' <remarks></remarks>
  Sub New(full As String, abbreviation As String, Optional txtabbreviation As String = "")
    fullName = full
    abbreviatedName = abbreviation
    abbreviatedTxt = txtabbreviation
  End Sub
End Class



