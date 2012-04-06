Imports System.Web.UI.WebControls
Imports System.Text
Imports System.Web.UI
Imports System.IO

Public Class form
  '04 - DYNAMIC OBJECTS
  '-----------------------------------------------------------------------

  'Adds Submit Button to Form
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="text"></param>
  ''' <param name="cssClass"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function button(ByVal id As String, ByVal name As String, ByVal text As String, ByVal cssClass As String) As Button
    Using this As New Button
      With this
        .Text = text
        .CssClass = cssClass
        .ID = id
      End With

      this.Attributes.Add("name", name)
      Return this
    End Using
  End Function


  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="sel"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function StateOptions(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal sel As String) As String
    Dim this As New StringBuilder
    For Each state In commonData.usStates()
      this.Append("<option value=""" & state.abbreviatedName & """" & If(sel = state.abbreviatedName, " selected", "") & ">" & state.fullName & "</option>")
    Next
    Return "<select id=""" & id & """ class=""" & cssclass & """ name=""" & name & """>" & this.ToString & "</select>"
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="sel"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function CountryOptions(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal sel As String) As String
    Dim this As New StringBuilder
    For Each country In commonData.countries()
      this.Append("<option value=""" & country & """" & If(sel = country, " selected", "") & ">" & country & "</option>")
    Next
    Return "<select id=""" & id & """ class=""" & cssclass & """ name=""" & name & """>" & this.ToString & "</select>"
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="sel"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function MonthOptions(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal sel As String) As String
    Using this As New DropDownList
      For Each month In commonData.months()
        this.Items.Add(New ListItem(month.fullName, month.abbreviatedName))
      Next
      If sel <> "" Then
        this.SelectedValue = sel
      End If

      this.CssClass = cssclass
      this.ID = id

      Return rc(this)
    End Using
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="name"></param>
  ''' <param name="vals"></param>
  ''' <param name="lbls"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function StaticSelect(ByVal name As String, ByVal vals As String, ByVal lbls As String) As String
    Dim ret As New StringBuilder
    Dim valarr As String() = vals.Split(","c)
    Dim lblarr As String() = lbls.Split(","c)
    With ret
      .Append("<select id=""" & name & """ name=""" & name & """>")
      For i As Integer = 0 To UBound(valarr)
        .Append("<option value=""" & valarr(i) & """>" & lblarr(i) & "</option>")
      Next
      .Append("</select>")
    End With
    Return ret.ToString

  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="range"></param>
  ''' <param name="selectedindex"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function numDropdown(ByVal id As String, ByVal range As Integer, Optional ByVal selectedindex As Integer = 0) As DropDownList
    Using ddl As New DropDownList
      ddl.Attributes.Add("name", id)
      With ddl.Items
        For i As Integer = 0 To range
          .Add(New ListItem(CStr(i), CStr(i)))
        Next
      End With
      If selectedindex <> 0 Then
        ddl.SelectedIndex = selectedindex
      End If
      Return ddl
    End Using
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="startRange"></param>
  ''' <param name="endRange"></param>
  ''' <param name="sel"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function numSelect(ByVal startRange As Integer, ByVal endRange As Integer, Optional ByVal sel As String = "") As DropDownList
    Using ddl As New DropDownList
      With ddl.Items
        For i As Integer = startRange To endRange
          .Add(New ListItem(CStr(i), CStr(i)))
        Next
      End With
      If sel <> "" Then
        ddl.SelectedValue = sel
      End If
      Return ddl
    End Using
  End Function


  'static ddl bound with optgroup
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="recs"></param>
  ''' <param name="name"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function GroupDDL(ByVal recs As Data.DataTable, ByVal name As String) As String
    '0=value
    '1=groupname
    '2=text title
    If hasrecs(recs) Then
      Dim sb As New StringBuilder
      Dim currentgroup As String = ""
      sb.Append("<select name=""" & name & """>" & vbCrLf)
      sb.Append("<option value=""0"">--</option>" & vbCrLf)
      For i As Integer = 0 To recs.Rows.Count - 1
        If i = 0 OrElse currentgroup <> recs.Rows(i)(1).ToString Then
          sb.Append("<optgroup label=""" & recs.Rows(i)(1).ToString & """ />")
          sb.Append(vbCrLf)
          currentgroup = recs.Rows(i)(1).ToString
        End If
        sb.Append("<option value=""" & recs.Rows(i)(0).ToString & """>" & recs.Rows(i)(2).ToString & "</option>" & vbCrLf)
      Next
      sb.Append("</select>" & vbCrLf)
      Return sb.ToString
    Else
      Return Nothing
    End If
  End Function





  'Returns ddl bound by two column datatable (0 = Value, 1=Text)
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="recs"></param>
  ''' <param name="SelectedValue"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function recDropdown(ByVal id As String, ByVal recs As Data.DataTable, Optional ByVal SelectedValue As String = "") As String
    Using ddl As New DropDownList
      Dim Item As ListItem = New ListItem()
      Item.Text = ""
      Item.Value = ""
      ddl.ID = id
      ddl.Attributes.Add("name", id)
      ddl.Items.Add(Item)
      ddl.AppendDataBoundItems = True
      With ddl.Items

        For i As Integer = 0 To recs.Rows.Count - 1
          .Add(New ListItem(recs.Rows(i)(1).ToString, recs.Rows(i)(0).ToString))
        Next
      End With
      If SelectedValue <> "" Then
        ddl.SelectedIndex = ddl.Items.IndexOf(ddl.Items.FindByValue(SelectedValue))
      End If
      Return rc(ddl)
    End Using
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function textbox(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("text", id, name, cssclass, value, placeholder)
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function password(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("password", id, name, cssclass, value, placeholder)
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function email(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("email", id, name, cssclass, value, placeholder)
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function URL(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("url", id, name, cssclass, value, placeholder)
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function search(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("search", id, name, cssclass, value, placeholder)
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function tel(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("tel", id, name, cssclass, value, placeholder)
  End Function


  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function number(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("number", id, name, cssclass, value, placeholder)
  End Function




  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function datetime(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("datetime", id, name, cssclass, value, placeholder)
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function dateField(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("date", id, name, cssclass, value, placeholder)
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function week(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("week", id, name, cssclass, value, placeholder)
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="value"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function time(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal value As String, Optional placeholder As String = "") As String
    Return form.genInput("time", id, name, cssclass, value, placeholder)
  End Function

  
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="type"></param>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="txt"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function genInput(ByVal type As String, ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal txt As String, Optional placeholder As String = "") As String
    Return "<input type=""" & type & """ value=""" & txt & """ name=""" & id & """ id=""" & id & """ class=""" & cssclass & """ placeholder=""" & placeholder & """ />"
  End Function


  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="txt"></param>
  ''' <param name="rows"></param>
  ''' <param name="cols"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function TextArea(ByVal id As String, ByVal name As String, ByVal cssclass As String, ByVal txt As String, Optional rows As Integer = 0, Optional cols As Integer = 0) As String
    Return "<textarea name=""" & name & """ id=""" & id & """ class=""" & cssclass & """ cols=""" & cols & """ rows=""" & rows & """>" & txt & "</textarea>"
  End Function

  





  'Returns ddl bound by two column datatable (0 = Value, 1=Text)
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="recs"></param>
  ''' <param name="SelectedValue"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function recCheckBoxList(ByVal id As String, ByVal recs As Data.DataTable, Optional ByVal SelectedValue As String = "") As String
    Using cbl As New CheckBoxList
      cbl.Attributes.Add("name", id)
      With cbl.Items
        For i As Integer = 0 To recs.Rows.Count - 1
          .Add(New ListItem(recs.Rows(i)(1).ToString, recs.Rows(i)(0).ToString))
        Next
      End With
      'If SelectedValue <> "" Then
      'ddl.SelectedIndex = ddl.Items.IndexOf(ddl.Items.FindByValue(SelectedValue))
      'End If
      Return rc(cbl)
    End Using
  End Function


  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssClass"></param>
  ''' <param name="val"></param>
  ''' <param name="selected"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function Checkbox(ByVal id As String, ByVal name As String, ByVal cssClass As String, ByVal val As String, ByVal selected As Boolean) As String
    Return "<input type=""checkbox"" value=""" & val & """ name=""" & name & """ id=""" & id & """ class=""" & cssClass & """ " & If(selected, "checked=""checked""", "") & " />"
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="name"></param>
  ''' <param name="cssClass"></param>
  ''' <param name="val"></param>
  ''' <param name="selected"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function Radio(ByVal id As String, ByVal name As String, ByVal cssClass As String, ByVal val As String, ByVal selected As Boolean) As String
    Return "<input type=""radio"" value=""" & val & """ name=""" & name & """ id=""" & id & """ class=""" & cssClass & """ " & If(selected, "checked=""checked""", "") & " />"
  End Function








  Public Enum input
    text = 1
    textarea = 2
    password = 3
    radioButton = 4
    radioGroup = 5
    selectField = 6
    multiSelect = 7
    numSelect = 8
    checkbox = 9
    checkboxList = 10
    email = 11
    url = 12
    number = 13
    search = 14
    tel = 15
    datetime = 16
    dateField = 17
    week = 18
    time = 19
    range = 21
    color = 22
    states = 23
    countries = 24
    months = 25
  End Enum

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="val"></param>
  ''' <param name="inputType"></param>
  ''' <param name="cssClass"></param>
  ''' <param name="rows"></param>
  ''' <param name="cols"></param>
  ''' <param name="name"></param>
  ''' <param name="valRecs"></param>
  ''' <param name="valIDRecs"></param>
  ''' <param name="selected"></param>
  ''' <param name="checked"></param>
  ''' <param name="required"></param>
  ''' <param name="pattern"></param>
  ''' <param name="placeholder"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function field(ByVal id As String,
                      ByVal val As String,
                      ByVal inputType As Integer,
                      Optional ByVal cssClass As String = "",
                      Optional rows As Integer = 0,
                      Optional cols As Integer = 0,
                      Optional name As String = "",
                      Optional valRecs As Data.DataTable = Nothing,
                      Optional valIDRecs As Data.DataTable = Nothing,
                      Optional selected As String = "",
                      Optional checked As Boolean = False,
                      Optional required As Boolean = False,
                      Optional pattern As String = "",
                      Optional placeholder As String = ""
                      ) As String

    Dim ret As String = ""



    Select Case inputType
      Case 1 'text = 1
        ret = form.textbox(id, name, cssClass, val, placeholder)
      Case 2 'textarea = 2
        ret = form.TextArea(id, name, cssClass, val, rows, cols)
      Case 3 'password = 3
        ret = form.password(id, name, cssClass, val, placeholder)
      Case 4 'radioButton = 4
      Case 5 'radioGroup = 5
      Case 6 'selectField = 6
        ret = form.recDropdown(id, valRecs, selected)
      Case 7 'multiSelect = 7
      Case 8 'numSelect = 8
      Case 9 'checkbox = 9
        ret = form.Checkbox(id, name, cssClass, val, checked)
      Case 10 'checkboxList = 10
      Case 11 ' email
        ret = form.email(id, name, cssClass, val, placeholder)
      Case 12 ' url
        ret = form.URL(id, name, cssClass, val, placeholder)
      Case 13 ' number
        ret = form.number(id, name, cssClass, val, placeholder)
      Case 14 ' search
        ret = form.search(id, name, cssClass, val, placeholder)
      Case 15 ' tel
        ret = form.tel(id, name, cssClass, val, placeholder)
      Case 16 ' datetime
        ret = form.datetime(id, name, cssClass, val, placeholder)
      Case 17 ' dateField
        ret = form.dateField(id, name, cssClass, val, placeholder)
      Case 18 ' week
        ret = form.week(id, name, cssClass, val, placeholder)
      Case 19 ' time
        ret = form.time(id, name, cssClass, val, placeholder)
      Case 21 ' range

      Case 22 ' color
      Case 23 'states = 9
        ret = form.StateOptions(id, name, cssClass, selected)
      Case 24 'countries = 10
        ret = form.CountryOptions(id, name, cssClass, selected)
      Case 25 'months = 11
        ret = form.MonthOptions(id, name, cssClass, selected)
      Case Else
        ret = Nothing
    End Select




    If ret IsNot Nothing Then
      If required Then
        Return ret.Replace("id=", " required=""required"" id=")
      Else
        Return ret
      End If

    Else
      Return Nothing
    End If

  End Function



End Class
