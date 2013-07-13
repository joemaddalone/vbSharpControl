VBSharp
====================

VBSharp is a collection of extensions and classes to make ASP.NET development faster.  This collection is seriously undocumented because I don't have the time to wite it all down and I am always updating it.
I use this codebase every single day and you may find it useful as well.  It works with VB.NET and C#.


Example: .forEach extension to Data.DataTable
---------------------

        Dim ret As New StringBuilder
        With ret
            read.sql("select title from manufacturer") _
                .forEach(Sub(r As Data.DataRow, i As Integer)   
                             .Append(__(r("title")) & html.br())
                         End Sub,
                         Sub() rW(ret.ToString),
                         Sub() .Append("There was no data!"))
        End With
    
Output with records:
	
	CompanyA<br />
	CompanyC<br />
	CompanyB<br />

Output with no records:
	
	There was no data!

Example: .template extension to Data.DataTable
---------------------
	dim ret as string = _
		read.sql("select title from manufacturer") _
			.template("${title}<br />"))
	rw(ret)

    
Output with records:
	
	CompanyA<br />
	CompanyC<br />
	CompanyB<br />


Example: .template extension with Zen coding
---------------------
    dim ret as string = _
        read.sql("select title from manufacturer") _
            .template(New zen("tr>td${title}").output,"<table>","</table>"))
    rw(ret)

    
Output with records:
    
    <table>
    <tr><td>CompanyA</td></tr>
    <tr><td>CompanyB</td></tr>
    <tr><td>CompanyC</td></tr>
    </table>




Example: CSV as Data.Datatable
---------------------    
    
    Dim recs As Data.DataTable =
      read.csv(PathOf("app_data/randomdata.csv"),True)

Example: Directory as Data.Datatable
---------------------    

    Dim recs As Data.DataTable =
      read.dir(PathOf("examples/forEach/"))

Example: Convert Data.Datatable to various formats
---------------------    

    (DataTable).toJSON()
    (DataTable).toJS("id-for-js-array")
    (DataTable).toCSV()
    (DataTable).toTable()

Shortcuts
---------------------    

    (control).AddLit(string)
    Adds literal to a control with .Text

    (control).AppendControl(control)
    Adds a control to a control

    (control).AddCSS(String)
    Adds <link href="{string}" rel="stylesheet" type="text/css" /> to control

    (control).AddJS(String)
    Adds <script src="{string}" type="text/javascript"></script> to control

    el(HTML-TAG,Inner Content,{attributes},{attribute values})
    Ex. el("div","Hellow World",{"id","class","style"},{"id","class","border:1px solid green"})
    Returns:
    <div id="id" class="class" style="border:1px solid green">Hellow World</div>

    html.ANY-HTML-TAG(inner-content)
    html.ANY-HTML-TAG(inner-content,id)
    html.ANY-HTML-TAG(inner-content,id,class)

    Ex.
    html.h1("Hello World!")
    html.h1("Hello World!","ID")
    html.h1("Hello World!","ID","CLASS")

    Returns:
        <h1>Hello World!</h1>
        <h1 id="ID">Hello World!</h1>
        <h1 id="ID" class="CLASS">Hello World!</h1>