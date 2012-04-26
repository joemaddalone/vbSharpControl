Public Class html



  Shared a_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("a", inner, id:=id, style:=cssclass)
  Shared abbr_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("abbr", inner, id:=id, style:=cssclass)
  Shared acronym_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("acronym", inner, id:=id, style:=cssclass)
  Shared address_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("address", inner, id:=id, style:=cssclass)
  Shared applet_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("applet", inner, id:=id, style:=cssclass)
  Shared area_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("area", inner, id:=id, style:=cssclass)
  Shared article_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("article", inner, id:=id, style:=cssclass)
  Shared aside_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("aside", inner, id:=id, style:=cssclass)
  Shared b_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("b", inner, id:=id, style:=cssclass)
  Shared base_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("base", inner, id:=id, style:=cssclass)
  Shared basefont_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("basefont", inner, id:=id, style:=cssclass)
  Shared bdo_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("bdo", inner, id:=id, style:=cssclass)
  Shared big_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("big", inner, id:=id, style:=cssclass)
  Shared blockquote_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("blockquote", inner, id:=id, style:=cssclass)
  Shared body_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("body", inner, id:=id, style:=cssclass)
  Shared button_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("button", inner, id:=id, style:=cssclass)
  Shared canvas_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("canvas", inner, id:=id, style:=cssclass)
  Shared caption_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("caption", inner, id:=id, style:=cssclass)
  Shared center_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("center", inner, id:=id, style:=cssclass)
  Shared cite_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("cite", inner, id:=id, style:=cssclass)
  Shared code_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("code", inner, id:=id, style:=cssclass)
  Shared col_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("col", inner, id:=id, style:=cssclass)
  Shared colgroup_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("colgroup", inner, id:=id, style:=cssclass)
  Shared command_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("command", inner, id:=id, style:=cssclass)
  Shared datalist_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("datalist", inner, id:=id, style:=cssclass)
  Shared dd_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("dd", inner, id:=id, style:=cssclass)
  Shared del_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("del", inner, id:=id, style:=cssclass)
  Shared details_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("details", inner, id:=id, style:=cssclass)
  Shared dfn_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("dfn", inner, id:=id, style:=cssclass)
  Shared dir_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("dir", inner, id:=id, style:=cssclass)
  Shared div_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("div", inner, id:=id, style:=cssclass)
  Shared dl_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("dl", inner, id:=id, style:=cssclass)
  Shared dt_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("dt", inner, id:=id, style:=cssclass)
  Shared em_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("em", inner, id:=id, style:=cssclass)
  Shared fieldset_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("fieldset", inner, id:=id, style:=cssclass)
  Shared figcaption_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("figcaption", inner, id:=id, style:=cssclass)
  Shared figure_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("figure", inner, id:=id, style:=cssclass)
  Shared font_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("font", inner, id:=id, style:=cssclass)
  Shared footer_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("footer", inner, id:=id, style:=cssclass)
  Shared form_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("form", inner, id:=id, style:=cssclass)
  Shared frame_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("frame", inner, id:=id, style:=cssclass)
  Shared frameset_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("frameset", inner, id:=id, style:=cssclass)
  Shared h1_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("h1", inner, id:=id, style:=cssclass)
  Shared h2_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("h2", inner, id:=id, style:=cssclass)
  Shared h3_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("h3", inner, id:=id, style:=cssclass)
  Shared h4_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("h4", inner, id:=id, style:=cssclass)
  Shared h5_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("h5", inner, id:=id, style:=cssclass)
  Shared h6_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("h6", inner, id:=id, style:=cssclass)
  Shared head_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("head", inner, id:=id, style:=cssclass)
  Shared header_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("header", inner, id:=id, style:=cssclass)
  Shared hgroup_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("hgroup", inner, id:=id, style:=cssclass)
  Shared hr_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("hr", inner, id:=id, style:=cssclass)
  Shared html_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("html", inner, id:=id, style:=cssclass)
  Shared i_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("i", inner, id:=id, style:=cssclass)
  Shared iframe_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("iframe", inner, id:=id, style:=cssclass)
  Shared img_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("img", inner, id:=id, style:=cssclass)
  Shared input_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("input", inner, id:=id, style:=cssclass)
  Shared ins_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("ins", inner, id:=id, style:=cssclass)
  Shared keygen_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("keygen", inner, id:=id, style:=cssclass)
  Shared kbd_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("kbd", inner, id:=id, style:=cssclass)
  Shared label_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("label", inner, id:=id, style:=cssclass)
  Shared legend_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("legend", inner, id:=id, style:=cssclass)
  Shared li_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("li", inner, id:=id, style:=cssclass)
  Shared link_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("link", inner, id:=id, style:=cssclass)
  Shared map_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("map", inner, id:=id, style:=cssclass)
  Shared mark_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("mark", inner, id:=id, style:=cssclass)
  Shared menu_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("menu", inner, id:=id, style:=cssclass)
  Shared meta_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("meta", inner, id:=id, style:=cssclass)
  Shared meter_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("meter", inner, id:=id, style:=cssclass)
  Shared nav_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("nav", inner, id:=id, style:=cssclass)
  Shared ol_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("ol", inner, id:=id, style:=cssclass)
  Shared optgroup_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("optgroup", inner, id:=id, style:=cssclass)
  Shared option_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("option", inner, id:=id, style:=cssclass)
  Shared output_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("output", inner, id:=id, style:=cssclass)
  Shared p_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("p", inner, id:=id, style:=cssclass)
  Shared param_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("param", inner, id:=id, style:=cssclass)
  Shared pre_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("pre", inner, id:=id, style:=cssclass)
  Shared progress_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("progress", inner, id:=id, style:=cssclass)
  Shared q_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("q", inner, id:=id, style:=cssclass)
  Shared rp_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("rp", inner, id:=id, style:=cssclass)
  Shared rt_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("rt", inner, id:=id, style:=cssclass)
  Shared ruby_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("ruby", inner, id:=id, style:=cssclass)
  Shared s_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("s", inner, id:=id, style:=cssclass)
  Shared samp_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("samp", inner, id:=id, style:=cssclass)
  Shared script_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("script", inner, id:=id, style:=cssclass)
  Shared section_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("section", inner, id:=id, style:=cssclass)
  Shared select_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("select", inner, id:=id, style:=cssclass)
  Shared small_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("small", inner, id:=id, style:=cssclass)
  Shared source_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("source", inner, id:=id, style:=cssclass)
  Shared span_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("span", inner, id:=id, style:=cssclass)
  Shared strike_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("strike", inner, id:=id, style:=cssclass)
  Shared strong_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("strong", inner, id:=id, style:=cssclass)
  Shared style_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("style", inner, id:=id, style:=cssclass)
  Shared sub_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("sub", inner, id:=id, style:=cssclass)
  Shared summary_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("summary", inner, id:=id, style:=cssclass)
  Shared sup_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("sup", inner, id:=id, style:=cssclass)
  Shared table_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("table", inner, id:=id, style:=cssclass)
  Shared tbody_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("tbody", inner, id:=id, style:=cssclass)
  Shared td_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("td", inner, id:=id, style:=cssclass)
  Shared textarea_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("textarea", inner, id:=id, style:=cssclass)
  Shared tfoot_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("tfoot", inner, id:=id, style:=cssclass)
  Shared th_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("th", inner, id:=id, style:=cssclass)
  Shared thead_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("thead", inner, id:=id, style:=cssclass)
  Shared time_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("time", inner, id:=id, style:=cssclass)
  Shared title_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("title", inner, id:=id, style:=cssclass)
  Shared tr_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("tr", inner, id:=id, style:=cssclass)
  Shared tt_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("tt", inner, id:=id, style:=cssclass)
  Shared u_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("u", inner, id:=id, style:=cssclass)
  Shared ul_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("ul", inner, id:=id, style:=cssclass)
  Shared var_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("var", inner, id:=id, style:=cssclass)
  Shared wbr_ID_Class As Func(Of String, String, String, String) = Function(inner, id, cssclass) tag("wbr", inner, id:=id, style:=cssclass)

  Shared Function a(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return a_ID_Class(inner, id, cssclass)
  End Function
  Shared Function a(inner As String, attr As String(), vals As String()) As String
    Return el("a", inner, attr, vals)
  End Function

  Shared Function abbr(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return abbr_ID_Class(inner, id, cssclass)
  End Function
  Shared Function abbr(inner As String, attr As String(), vals As String()) As String
    Return el("abbr", inner, attr, vals)
  End Function

  Shared Function acronym(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return acronym_ID_Class(inner, id, cssclass)
  End Function
  Shared Function acronym(inner As String, attr As String(), vals As String()) As String
    Return el("acronym", inner, attr, vals)
  End Function

  Shared Function address(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return address_ID_Class(inner, id, cssclass)
  End Function
  Shared Function address(inner As String, attr As String(), vals As String()) As String
    Return el("address", inner, attr, vals)
  End Function

  Shared Function area(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return area_ID_Class(inner, id, cssclass)
  End Function
  Shared Function area(inner As String, attr As String(), vals As String()) As String
    Return el("area", inner, attr, vals)
  End Function

  Shared Function article(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return article_ID_Class(inner, id, cssclass)
  End Function
  Shared Function article(inner As String, attr As String(), vals As String()) As String
    Return el("article", inner, attr, vals)
  End Function

  Shared Function aside(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return aside_ID_Class(inner, id, cssclass)
  End Function
  Shared Function aside(inner As String, attr As String(), vals As String()) As String
    Return el("aside", inner, attr, vals)
  End Function

  Shared Function b(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return b_ID_Class(inner, id, cssclass)
  End Function
  Shared Function b(inner As String, attr As String(), vals As String()) As String
    Return el("b", inner, attr, vals)
  End Function

  Shared Function base(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return base_ID_Class(inner, id, cssclass)
  End Function
  Shared Function base(inner As String, attr As String(), vals As String()) As String
    Return el("base", inner, attr, vals)
  End Function

  Shared Function basefont(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return basefont_ID_Class(inner, id, cssclass)
  End Function
  Shared Function basefont(inner As String, attr As String(), vals As String()) As String
    Return el("basefont", inner, attr, vals)
  End Function

  Shared Function bdo(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return bdo_ID_Class(inner, id, cssclass)
  End Function
  Shared Function bdo(inner As String, attr As String(), vals As String()) As String
    Return el("bdo", inner, attr, vals)
  End Function

  Shared Function big(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return big_ID_Class(inner, id, cssclass)
  End Function
  Shared Function big(inner As String, attr As String(), vals As String()) As String
    Return el("big", inner, attr, vals)
  End Function

  Shared Function blockquote(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return blockquote_ID_Class(inner, id, cssclass)
  End Function
  Shared Function blockquote(inner As String, attr As String(), vals As String()) As String
    Return el("blockquote", inner, attr, vals)
  End Function

  Shared Function body(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return body_ID_Class(inner, id, cssclass)
  End Function
  Shared Function body(inner As String, attr As String(), vals As String()) As String
    Return el("body", inner, attr, vals)
  End Function

  Shared Function button(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return button_ID_Class(inner, id, cssclass)
  End Function
  Shared Function button(inner As String, attr As String(), vals As String()) As String
    Return el("button", inner, attr, vals)
  End Function

  Shared Function canvas(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return canvas_ID_Class(inner, id, cssclass)
  End Function
  Shared Function canvas(inner As String, attr As String(), vals As String()) As String
    Return el("canvas", inner, attr, vals)
  End Function

  Shared Function caption(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return caption_ID_Class(inner, id, cssclass)
  End Function
  Shared Function caption(inner As String, attr As String(), vals As String()) As String
    Return el("caption", inner, attr, vals)
  End Function

  Shared Function center(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return center_ID_Class(inner, id, cssclass)
  End Function
  Shared Function center(inner As String, attr As String(), vals As String()) As String
    Return el("center", inner, attr, vals)
  End Function

  Shared Function cite(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return cite_ID_Class(inner, id, cssclass)
  End Function
  Shared Function cite(inner As String, attr As String(), vals As String()) As String
    Return el("cite", inner, attr, vals)
  End Function

  Shared Function code(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return code_ID_Class(inner, id, cssclass)
  End Function
  Shared Function code(inner As String, attr As String(), vals As String()) As String
    Return el("code", inner, attr, vals)
  End Function

  Shared Function col(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return col_ID_Class(inner, id, cssclass)
  End Function
  Shared Function col(inner As String, attr As String(), vals As String()) As String
    Return el("col", inner, attr, vals)
  End Function

  Shared Function colgroup(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return colgroup_ID_Class(inner, id, cssclass)
  End Function
  Shared Function colgroup(inner As String, attr As String(), vals As String()) As String
    Return el("colgroup", inner, attr, vals)
  End Function

  Shared Function command(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return command_ID_Class(inner, id, cssclass)
  End Function
  Shared Function command(inner As String, attr As String(), vals As String()) As String
    Return el("command", inner, attr, vals)
  End Function

  Shared Function datalist(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return datalist_ID_Class(inner, id, cssclass)
  End Function
  Shared Function datalist(inner As String, attr As String(), vals As String()) As String
    Return el("datalist", inner, attr, vals)
  End Function

  Shared Function dd(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return dd_ID_Class(inner, id, cssclass)
  End Function
  Shared Function dd(inner As String, attr As String(), vals As String()) As String
    Return el("dd", inner, attr, vals)
  End Function

  Shared Function del(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return del_ID_Class(inner, id, cssclass)
  End Function
  Shared Function del(inner As String, attr As String(), vals As String()) As String
    Return el("del", inner, attr, vals)
  End Function

  Shared Function details(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return details_ID_Class(inner, id, cssclass)
  End Function
  Shared Function details(inner As String, attr As String(), vals As String()) As String
    Return el("details", inner, attr, vals)
  End Function

  Shared Function dfn(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return dfn_ID_Class(inner, id, cssclass)
  End Function
  Shared Function dfn(inner As String, attr As String(), vals As String()) As String
    Return el("dfn", inner, attr, vals)
  End Function

  Shared Function dir(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return dir_ID_Class(inner, id, cssclass)
  End Function
  Shared Function dir(inner As String, attr As String(), vals As String()) As String
    Return el("dir", inner, attr, vals)
  End Function

  Shared Function div(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return div_ID_Class(inner, id, cssclass)
  End Function
  Shared Function div(inner As String, attr As String(), vals As String()) As String
    Return el("div", inner, attr, vals)
  End Function

  Shared Function dl(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return dl_ID_Class(inner, id, cssclass)
  End Function
  Shared Function dl(inner As String, attr As String(), vals As String()) As String
    Return el("dl", inner, attr, vals)
  End Function

  Shared Function dt(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return dt_ID_Class(inner, id, cssclass)
  End Function
  Shared Function dt(inner As String, attr As String(), vals As String()) As String
    Return el("dt", inner, attr, vals)
  End Function

  Shared Function em(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return em_ID_Class(inner, id, cssclass)
  End Function
  Shared Function em(inner As String, attr As String(), vals As String()) As String
    Return el("em", inner, attr, vals)
  End Function

  Shared Function fieldset(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return fieldset_ID_Class(inner, id, cssclass)
  End Function
  Shared Function fieldset(inner As String, attr As String(), vals As String()) As String
    Return el("fieldset", inner, attr, vals)
  End Function

  Shared Function figcaption(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return figcaption_ID_Class(inner, id, cssclass)
  End Function
  Shared Function figcaption(inner As String, attr As String(), vals As String()) As String
    Return el("figcaption", inner, attr, vals)
  End Function

  Shared Function figure(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return figure_ID_Class(inner, id, cssclass)
  End Function
  Shared Function figure(inner As String, attr As String(), vals As String()) As String
    Return el("figure", inner, attr, vals)
  End Function

  Shared Function font(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return font_ID_Class(inner, id, cssclass)
  End Function
  Shared Function font(inner As String, attr As String(), vals As String()) As String
    Return el("font", inner, attr, vals)
  End Function

  Shared Function footer(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return footer_ID_Class(inner, id, cssclass)
  End Function
  Shared Function footer(inner As String, attr As String(), vals As String()) As String
    Return el("footer", inner, attr, vals)
  End Function

  Shared Function form(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return form_ID_Class(inner, id, cssclass)
  End Function
  Shared Function form(inner As String, attr As String(), vals As String()) As String
    Return el("form", inner, attr, vals)
  End Function

  Shared Function frame(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return frame_ID_Class(inner, id, cssclass)
  End Function
  Shared Function frame(inner As String, attr As String(), vals As String()) As String
    Return el("frame", inner, attr, vals)
  End Function

  Shared Function frameset(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return frameset_ID_Class(inner, id, cssclass)
  End Function
  Shared Function frameset(inner As String, attr As String(), vals As String()) As String
    Return el("frameset", inner, attr, vals)
  End Function

  Shared Function h1(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return h1_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h1(inner As String, attr As String(), vals As String()) As String
    Return el("h1", inner, attr, vals)
  End Function

  Shared Function h2(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return h2_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h2(inner As String, attr As String(), vals As String()) As String
    Return el("h2", inner, attr, vals)
  End Function

  Shared Function h3(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return h3_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h3(inner As String, attr As String(), vals As String()) As String
    Return el("h3", inner, attr, vals)
  End Function

  Shared Function h4(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return h4_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h4(inner As String, attr As String(), vals As String()) As String
    Return el("h4", inner, attr, vals)
  End Function

  Shared Function h5(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return h5_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h5(inner As String, attr As String(), vals As String()) As String
    Return el("h5", inner, attr, vals)
  End Function

  Shared Function h6(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return h6_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h6(inner As String, attr As String(), vals As String()) As String
    Return el("h6", inner, attr, vals)
  End Function

  Shared Function head(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return head_ID_Class(inner, id, cssclass)
  End Function
  Shared Function head(inner As String, attr As String(), vals As String()) As String
    Return el("head", inner, attr, vals)
  End Function

  Shared Function header(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return header_ID_Class(inner, id, cssclass)
  End Function
  Shared Function header(inner As String, attr As String(), vals As String()) As String
    Return el("header", inner, attr, vals)
  End Function

  Shared Function hgroup(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return hgroup_ID_Class(inner, id, cssclass)
  End Function
  Shared Function hgroup(inner As String, attr As String(), vals As String()) As String
    Return el("hgroup", inner, attr, vals)
  End Function

  Shared Function hr(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return hr_ID_Class(inner, id, cssclass)
  End Function
  Shared Function hr(inner As String, attr As String(), vals As String()) As String
    Return el("hr", inner, attr, vals)
  End Function

  Shared Function html(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return html_ID_Class(inner, id, cssclass)
  End Function
  Shared Function html(inner As String, attr As String(), vals As String()) As String
    Return el("html", inner, attr, vals)
  End Function

  Shared Function i(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return i_ID_Class(inner, id, cssclass)
  End Function
  Shared Function i(inner As String, attr As String(), vals As String()) As String
    Return el("i", inner, attr, vals)
  End Function

  Shared Function iframe(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return iframe_ID_Class(inner, id, cssclass)
  End Function
  Shared Function iframe(inner As String, attr As String(), vals As String()) As String
    Return el("iframe", inner, attr, vals)
  End Function

  Shared Function img(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return img_ID_Class(inner, id, cssclass)
  End Function
  Shared Function img(inner As String, attr As String(), vals As String()) As String
    Return el("img", inner, attr, vals)
  End Function

  Shared Function input(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return input_ID_Class(inner, id, cssclass)
  End Function
  Shared Function input(inner As String, attr As String(), vals As String()) As String
    Return el("input", inner, attr, vals)
  End Function

  Shared Function ins(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return ins_ID_Class(inner, id, cssclass)
  End Function
  Shared Function ins(inner As String, attr As String(), vals As String()) As String
    Return el("ins", inner, attr, vals)
  End Function

  Shared Function keygen(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return keygen_ID_Class(inner, id, cssclass)
  End Function
  Shared Function keygen(inner As String, attr As String(), vals As String()) As String
    Return el("keygen", inner, attr, vals)
  End Function

  Shared Function kbd(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return kbd_ID_Class(inner, id, cssclass)
  End Function
  Shared Function kbd(inner As String, attr As String(), vals As String()) As String
    Return el("kbd", inner, attr, vals)
  End Function

  Shared Function label(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return label_ID_Class(inner, id, cssclass)
  End Function
  Shared Function label(inner As String, attr As String(), vals As String()) As String
    Return el("label", inner, attr, vals)
  End Function

  Shared Function legend(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return legend_ID_Class(inner, id, cssclass)
  End Function
  Shared Function legend(inner As String, attr As String(), vals As String()) As String
    Return el("legend", inner, attr, vals)
  End Function

  Shared Function li(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return li_ID_Class(inner, id, cssclass)
  End Function
  Shared Function li(inner As String, attr As String(), vals As String()) As String
    Return el("li", inner, attr, vals)
  End Function

  Shared Function map(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return map_ID_Class(inner, id, cssclass)
  End Function
  Shared Function map(inner As String, attr As String(), vals As String()) As String
    Return el("map", inner, attr, vals)
  End Function

  Shared Function mark(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return mark_ID_Class(inner, id, cssclass)
  End Function
  Shared Function mark(inner As String, attr As String(), vals As String()) As String
    Return el("mark", inner, attr, vals)
  End Function

  Shared Function menu(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return menu_ID_Class(inner, id, cssclass)
  End Function
  Shared Function menu(inner As String, attr As String(), vals As String()) As String
    Return el("menu", inner, attr, vals)
  End Function

  Shared Function meta(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return meta_ID_Class(inner, id, cssclass)
  End Function
  Shared Function meta(inner As String, attr As String(), vals As String()) As String
    Return el("meta", inner, attr, vals)
  End Function

  Shared Function meter(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return meter_ID_Class(inner, id, cssclass)
  End Function
  Shared Function meter(inner As String, attr As String(), vals As String()) As String
    Return el("meter", inner, attr, vals)
  End Function

  Shared Function nav(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return nav_ID_Class(inner, id, cssclass)
  End Function
  Shared Function nav(inner As String, attr As String(), vals As String()) As String
    Return el("nav", inner, attr, vals)
  End Function

  Shared Function ol(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return ol_ID_Class(inner, id, cssclass)
  End Function
  Shared Function ol(inner As String, attr As String(), vals As String()) As String
    Return el("ol", inner, attr, vals)
  End Function

  Shared Function optgroup(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return optgroup_ID_Class(inner, id, cssclass)
  End Function
  Shared Function optgroup(inner As String, attr As String(), vals As String()) As String
    Return el("optgroup", inner, attr, vals)
  End Function

  Shared Function output(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return output_ID_Class(inner, id, cssclass)
  End Function
  Shared Function output(inner As String, attr As String(), vals As String()) As String
    Return el("output", inner, attr, vals)
  End Function

  Shared Function p(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return p_ID_Class(inner, id, cssclass)
  End Function
  Shared Function p(inner As String, attr As String(), vals As String()) As String
    Return el("p", inner, attr, vals)
  End Function

  Shared Function param(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return param_ID_Class(inner, id, cssclass)
  End Function
  Shared Function param(inner As String, attr As String(), vals As String()) As String
    Return el("param", inner, attr, vals)
  End Function

  Shared Function pre(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return pre_ID_Class(inner, id, cssclass)
  End Function
  Shared Function pre(inner As String, attr As String(), vals As String()) As String
    Return el("pre", inner, attr, vals)
  End Function

  Shared Function progress(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return progress_ID_Class(inner, id, cssclass)
  End Function
  Shared Function progress(inner As String, attr As String(), vals As String()) As String
    Return el("progress", inner, attr, vals)
  End Function

  Shared Function q(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return q_ID_Class(inner, id, cssclass)
  End Function
  Shared Function q(inner As String, attr As String(), vals As String()) As String
    Return el("q", inner, attr, vals)
  End Function

  Shared Function rp(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return rp_ID_Class(inner, id, cssclass)
  End Function
  Shared Function rp(inner As String, attr As String(), vals As String()) As String
    Return el("rp", inner, attr, vals)
  End Function

  Shared Function rt(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return rt_ID_Class(inner, id, cssclass)
  End Function
  Shared Function rt(inner As String, attr As String(), vals As String()) As String
    Return el("rt", inner, attr, vals)
  End Function

  Shared Function ruby(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return ruby_ID_Class(inner, id, cssclass)
  End Function
  Shared Function ruby(inner As String, attr As String(), vals As String()) As String
    Return el("ruby", inner, attr, vals)
  End Function

  Shared Function s(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return s_ID_Class(inner, id, cssclass)
  End Function
  Shared Function s(inner As String, attr As String(), vals As String()) As String
    Return el("s", inner, attr, vals)
  End Function

  Shared Function samp(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return samp_ID_Class(inner, id, cssclass)
  End Function
  Shared Function samp(inner As String, attr As String(), vals As String()) As String
    Return el("samp", inner, attr, vals)
  End Function

  Shared Function script(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return script_ID_Class(inner, id, cssclass)
  End Function
  Shared Function script(inner As String, attr As String(), vals As String()) As String
    Return el("script", inner, attr, vals)
  End Function

  Shared Function section(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return section_ID_Class(inner, id, cssclass)
  End Function
  Shared Function section(inner As String, attr As String(), vals As String()) As String
    Return el("section", inner, attr, vals)
  End Function

  Shared Function small(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return small_ID_Class(inner, id, cssclass)
  End Function
  Shared Function small(inner As String, attr As String(), vals As String()) As String
    Return el("small", inner, attr, vals)
  End Function

  Shared Function source(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return source_ID_Class(inner, id, cssclass)
  End Function
  Shared Function source(inner As String, attr As String(), vals As String()) As String
    Return el("source", inner, attr, vals)
  End Function

  Shared Function span(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return span_ID_Class(inner, id, cssclass)
  End Function
  Shared Function span(inner As String, attr As String(), vals As String()) As String
    Return el("span", inner, attr, vals)
  End Function

  Shared Function strike(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return strike_ID_Class(inner, id, cssclass)
  End Function
  Shared Function strike(inner As String, attr As String(), vals As String()) As String
    Return el("strike", inner, attr, vals)
  End Function

  Shared Function strong(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return strong_ID_Class(inner, id, cssclass)
  End Function
  Shared Function strong(inner As String, attr As String(), vals As String()) As String
    Return el("strong", inner, attr, vals)
  End Function

  Shared Function style(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return style_ID_Class(inner, id, cssclass)
  End Function
  Shared Function style(inner As String, attr As String(), vals As String()) As String
    Return el("style", inner, attr, vals)
  End Function

  Shared Function summary(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return summary_ID_Class(inner, id, cssclass)
  End Function
  Shared Function summary(inner As String, attr As String(), vals As String()) As String
    Return el("summary", inner, attr, vals)
  End Function

  Shared Function sup(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return sup_ID_Class(inner, id, cssclass)
  End Function
  Shared Function sup(inner As String, attr As String(), vals As String()) As String
    Return el("sup", inner, attr, vals)
  End Function

  Shared Function table(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return table_ID_Class(inner, id, cssclass)
  End Function
  Shared Function table(inner As String, attr As String(), vals As String()) As String
    Return el("table", inner, attr, vals)
  End Function

  Shared Function tbody(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return tbody_ID_Class(inner, id, cssclass)
  End Function
  Shared Function tbody(inner As String, attr As String(), vals As String()) As String
    Return el("tbody", inner, attr, vals)
  End Function

  Shared Function td(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return td_ID_Class(inner, id, cssclass)
  End Function
  Shared Function td(inner As String, attr As String(), vals As String()) As String
    Return el("td", inner, attr, vals)
  End Function

  Shared Function th(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return th_ID_Class(inner, id, cssclass)
  End Function
  Shared Function th(inner As String, attr As String(), vals As String()) As String
    Return el("th", inner, attr, vals)
  End Function

  Shared Function textarea(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return textarea_ID_Class(inner, id, cssclass)
  End Function
  Shared Function textarea(inner As String, attr As String(), vals As String()) As String
    Return el("textarea", inner, attr, vals)
  End Function

  Shared Function tfoot(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return tfoot_ID_Class(inner, id, cssclass)
  End Function
  Shared Function tfoot(inner As String, attr As String(), vals As String()) As String
    Return el("tfoot", inner, attr, vals)
  End Function

  Shared Function thead(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return thead_ID_Class(inner, id, cssclass)
  End Function
  Shared Function thead(inner As String, attr As String(), vals As String()) As String
    Return el("thead", inner, attr, vals)
  End Function

  Shared Function time(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return time_ID_Class(inner, id, cssclass)
  End Function
  Shared Function time(inner As String, attr As String(), vals As String()) As String
    Return el("time", inner, attr, vals)
  End Function

  Shared Function title(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return title_ID_Class(inner, id, cssclass)
  End Function
  Shared Function title(inner As String, attr As String(), vals As String()) As String
    Return el("title", inner, attr, vals)
  End Function

  Shared Function tr(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return tr_ID_Class(inner, id, cssclass)
  End Function
  Shared Function tr(inner As String, attr As String(), vals As String()) As String
    Return el("tr", inner, attr, vals)
  End Function

  Shared Function tt(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return tt_ID_Class(inner, id, cssclass)
  End Function
  Shared Function tt(inner As String, attr As String(), vals As String()) As String
    Return el("tt", inner, attr, vals)
  End Function

  Shared Function u(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return u_ID_Class(inner, id, cssclass)
  End Function
  Shared Function u(inner As String, attr As String(), vals As String()) As String
    Return el("u", inner, attr, vals)
  End Function

  Shared Function ul(inner As String, Optional id As String = "", Optional cssclass As String = "") As String
    Return ul_ID_Class(inner, id, cssclass)
  End Function
  Shared Function ul(inner As String, attr As String(), vals As String()) As String
    Return el("ul", inner, attr, vals)
  End Function





  Shared Function br() As String
    Return "<br />"
  End Function
End Class
