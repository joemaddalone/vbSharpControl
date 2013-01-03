VBSharp
====================

VBSharp is a collection of extensions and classes to make ASP.NET development faster.  This collection is seriously undocumented because I don't have the time to wite it all down and I am always updating it.  I use this codebase every single day ans you may find it useful as well.  It works with VB.NET and C#.


Example: .forEach extension to Data.DataTable

    Sub start() Handles Me.Load
        Dim ret As New StringBuilder
        With ret
            read.sql("select * from manufacturer") _
                .forEach(Sub(r As Data.DataRow, i As Integer)
                             .Append(__(r("title")) & html.br())
                         End Sub,
                         Sub() rW(ret.ToString),
                         Sub() .Append("There was no data!"))
        End With
    End Sub
    
Output with records:
	
	CompanyA<br />
	CompanyC<br />
	CompanyB<br />

Output with no records:
	There was no data!