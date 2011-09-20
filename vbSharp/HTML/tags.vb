Public Class html


  Shared a_Generic As Func(Of String, String) = Function(inner) tag("a", inner)
  Shared abbr_Generic As Func(Of String, String) = Function(inner) tag("abbr", inner)
  Shared acronym_Generic As Func(Of String, String) = Function(inner) tag("acronym", inner)
  Shared address_Generic As Func(Of String, String) = Function(inner) tag("address", inner)
  Shared applet_Generic As Func(Of String, String) = Function(inner) tag("applet", inner)
  Shared area_Generic As Func(Of String, String) = Function(inner) tag("area", inner)
  Shared article_Generic As Func(Of String, String) = Function(inner) tag("article", inner)
  Shared aside_Generic As Func(Of String, String) = Function(inner) tag("aside", inner)
  Shared b_Generic As Func(Of String, String) = Function(inner) tag("b", inner)
  Shared base_Generic As Func(Of String, String) = Function(inner) tag("base", inner)
  Shared basefont_Generic As Func(Of String, String) = Function(inner) tag("basefont", inner)
  Shared bdo_Generic As Func(Of String, String) = Function(inner) tag("bdo", inner)
  Shared big_Generic As Func(Of String, String) = Function(inner) tag("big", inner)
  Shared blockquote_Generic As Func(Of String, String) = Function(inner) tag("blockquote", inner)
  Shared body_Generic As Func(Of String, String) = Function(inner) tag("body", inner)
  Shared br_Generic As Func(Of String, String) = Function(inner) tag("br", inner)
  Shared button_Generic As Func(Of String, String) = Function(inner) tag("button", inner)
  Shared canvas_Generic As Func(Of String, String) = Function(inner) tag("canvas", inner)
  Shared caption_Generic As Func(Of String, String) = Function(inner) tag("caption", inner)
  Shared center_Generic As Func(Of String, String) = Function(inner) tag("center", inner)
  Shared cite_Generic As Func(Of String, String) = Function(inner) tag("cite", inner)
  Shared code_Generic As Func(Of String, String) = Function(inner) tag("code", inner)
  Shared col_Generic As Func(Of String, String) = Function(inner) tag("col", inner)
  Shared colgroup_Generic As Func(Of String, String) = Function(inner) tag("colgroup", inner)
  Shared command_Generic As Func(Of String, String) = Function(inner) tag("command", inner)
  Shared datalist_Generic As Func(Of String, String) = Function(inner) tag("datalist", inner)
  Shared dd_Generic As Func(Of String, String) = Function(inner) tag("dd", inner)
  Shared del_Generic As Func(Of String, String) = Function(inner) tag("del", inner)
  Shared details_Generic As Func(Of String, String) = Function(inner) tag("details", inner)
  Shared dfn_Generic As Func(Of String, String) = Function(inner) tag("dfn", inner)
  Shared dir_Generic As Func(Of String, String) = Function(inner) tag("dir", inner)
  Shared div_Generic As Func(Of String, String) = Function(inner) tag("div", inner)
  Shared dl_Generic As Func(Of String, String) = Function(inner) tag("dl", inner)
  Shared dt_Generic As Func(Of String, String) = Function(inner) tag("dt", inner)
  Shared em_Generic As Func(Of String, String) = Function(inner) tag("em", inner)
  Shared fieldset_Generic As Func(Of String, String) = Function(inner) tag("fieldset", inner)
  Shared figcaption_Generic As Func(Of String, String) = Function(inner) tag("figcaption", inner)
  Shared figure_Generic As Func(Of String, String) = Function(inner) tag("figure", inner)
  Shared font_Generic As Func(Of String, String) = Function(inner) tag("font", inner)
  Shared footer_Generic As Func(Of String, String) = Function(inner) tag("footer", inner)
  Shared form_Generic As Func(Of String, String) = Function(inner) tag("form", inner)
  Shared frame_Generic As Func(Of String, String) = Function(inner) tag("frame", inner)
  Shared frameset_Generic As Func(Of String, String) = Function(inner) tag("frameset", inner)
  Shared h1_Generic As Func(Of String, String) = Function(inner) tag("h1", inner)
  Shared h2_Generic As Func(Of String, String) = Function(inner) tag("h2", inner)
  Shared h3_Generic As Func(Of String, String) = Function(inner) tag("h3", inner)
  Shared h4_Generic As Func(Of String, String) = Function(inner) tag("h4", inner)
  Shared h5_Generic As Func(Of String, String) = Function(inner) tag("h5", inner)
  Shared h6_Generic As Func(Of String, String) = Function(inner) tag("h6", inner)
  Shared head_Generic As Func(Of String, String) = Function(inner) tag("head", inner)
  Shared header_Generic As Func(Of String, String) = Function(inner) tag("header", inner)
  Shared hgroup_Generic As Func(Of String, String) = Function(inner) tag("hgroup", inner)
  Shared hr_Generic As Func(Of String, String) = Function(inner) tag("hr", inner)
  Shared html_Generic As Func(Of String, String) = Function(inner) tag("html", inner)
  Shared i_Generic As Func(Of String, String) = Function(inner) tag("i", inner)
  Shared iframe_Generic As Func(Of String, String) = Function(inner) tag("iframe", inner)
  Shared img_Generic As Func(Of String, String) = Function(inner) tag("img", inner)
  Shared input_Generic As Func(Of String, String) = Function(inner) tag("input", inner)
  Shared ins_Generic As Func(Of String, String) = Function(inner) tag("ins", inner)
  Shared keygen_Generic As Func(Of String, String) = Function(inner) tag("keygen", inner)
  Shared kbd_Generic As Func(Of String, String) = Function(inner) tag("kbd", inner)
  Shared label_Generic As Func(Of String, String) = Function(inner) tag("label", inner)
  Shared legend_Generic As Func(Of String, String) = Function(inner) tag("legend", inner)
  Shared li_Generic As Func(Of String, String) = Function(inner) tag("li", inner)
  Shared link_Generic As Func(Of String, String) = Function(inner) tag("link", inner)
  Shared map_Generic As Func(Of String, String) = Function(inner) tag("map", inner)
  Shared mark_Generic As Func(Of String, String) = Function(inner) tag("mark", inner)
  Shared menu_Generic As Func(Of String, String) = Function(inner) tag("menu", inner)
  Shared meta_Generic As Func(Of String, String) = Function(inner) tag("meta", inner)
  Shared meter_Generic As Func(Of String, String) = Function(inner) tag("meter", inner)
  Shared nav_Generic As Func(Of String, String) = Function(inner) tag("nav", inner)
  Shared ol_Generic As Func(Of String, String) = Function(inner) tag("ol", inner)
  Shared optgroup_Generic As Func(Of String, String) = Function(inner) tag("optgroup", inner)
  Shared option_Generic As Func(Of String, String) = Function(inner) tag("option", inner)
  Shared output_Generic As Func(Of String, String) = Function(inner) tag("output", inner)
  Shared p_Generic As Func(Of String, String) = Function(inner) tag("p", inner)
  Shared param_Generic As Func(Of String, String) = Function(inner) tag("param", inner)
  Shared pre_Generic As Func(Of String, String) = Function(inner) tag("pre", inner)
  Shared progress_Generic As Func(Of String, String) = Function(inner) tag("progress", inner)
  Shared q_Generic As Func(Of String, String) = Function(inner) tag("q", inner)
  Shared rp_Generic As Func(Of String, String) = Function(inner) tag("rp", inner)
  Shared rt_Generic As Func(Of String, String) = Function(inner) tag("rt", inner)
  Shared ruby_Generic As Func(Of String, String) = Function(inner) tag("ruby", inner)
  Shared s_Generic As Func(Of String, String) = Function(inner) tag("s", inner)
  Shared samp_Generic As Func(Of String, String) = Function(inner) tag("samp", inner)
  Shared script_Generic As Func(Of String, String) = Function(inner) tag("script", inner)
  Shared section_Generic As Func(Of String, String) = Function(inner) tag("section", inner)
  Shared select_Generic As Func(Of String, String) = Function(inner) tag("select", inner)
  Shared small_Generic As Func(Of String, String) = Function(inner) tag("small", inner)
  Shared source_Generic As Func(Of String, String) = Function(inner) tag("source", inner)
  Shared span_Generic As Func(Of String, String) = Function(inner) tag("span", inner)
  Shared strike_Generic As Func(Of String, String) = Function(inner) tag("strike", inner)
  Shared strong_Generic As Func(Of String, String) = Function(inner) tag("strong", inner)
  Shared style_Generic As Func(Of String, String) = Function(inner) tag("style", inner)
  Shared sub_Generic As Func(Of String, String) = Function(inner) tag("sub", inner)
  Shared summary_Generic As Func(Of String, String) = Function(inner) tag("summary", inner)
  Shared sup_Generic As Func(Of String, String) = Function(inner) tag("sup", inner)
  Shared table_Generic As Func(Of String, String) = Function(inner) tag("table", inner)
  Shared tbody_Generic As Func(Of String, String) = Function(inner) tag("tbody", inner)
  Shared td_Generic As Func(Of String, String) = Function(inner) tag("td", inner)
  Shared textarea_Generic As Func(Of String, String) = Function(inner) tag("textarea", inner)
  Shared tfoot_Generic As Func(Of String, String) = Function(inner) tag("tfoot", inner)
  Shared th_Generic As Func(Of String, String) = Function(inner) tag("th", inner)
  Shared thead_Generic As Func(Of String, String) = Function(inner) tag("thead", inner)
  Shared time_Generic As Func(Of String, String) = Function(inner) tag("time", inner)
  Shared title_Generic As Func(Of String, String) = Function(inner) tag("title", inner)
  Shared tr_Generic As Func(Of String, String) = Function(inner) tag("tr", inner)
  Shared tt_Generic As Func(Of String, String) = Function(inner) tag("tt", inner)
  Shared u_Generic As Func(Of String, String) = Function(inner) tag("u", inner)
  Shared ul_Generic As Func(Of String, String) = Function(inner) tag("ul", inner)
  Shared var_Generic As Func(Of String, String) = Function(inner) tag("var", inner)
  Shared wbr_Generic As Func(Of String, String) = Function(inner) tag("wbr", inner)

  Shared a_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("a", inner, style:=cssclass)
  Shared abbr_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("abbr", inner, style:=cssclass)
  Shared acronym_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("acronym", inner, style:=cssclass)
  Shared address_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("address", inner, style:=cssclass)
  Shared applet_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("applet", inner, style:=cssclass)
  Shared area_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("area", inner, style:=cssclass)
  Shared article_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("article", inner, style:=cssclass)
  Shared aside_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("aside", inner, style:=cssclass)
  Shared b_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("b", inner, style:=cssclass)
  Shared base_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("base", inner, style:=cssclass)
  Shared basefont_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("basefont", inner, style:=cssclass)
  Shared bdo_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("bdo", inner, style:=cssclass)
  Shared big_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("big", inner, style:=cssclass)
  Shared blockquote_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("blockquote", inner, style:=cssclass)
  Shared body_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("body", inner, style:=cssclass)
  Shared button_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("button", inner, style:=cssclass)
  Shared canvas_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("canvas", inner, style:=cssclass)
  Shared caption_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("caption", inner, style:=cssclass)
  Shared center_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("center", inner, style:=cssclass)
  Shared cite_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("cite", inner, style:=cssclass)
  Shared code_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("code", inner, style:=cssclass)
  Shared col_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("col", inner, style:=cssclass)
  Shared colgroup_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("colgroup", inner, style:=cssclass)
  Shared command_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("command", inner, style:=cssclass)
  Shared datalist_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("datalist", inner, style:=cssclass)
  Shared dd_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("dd", inner, style:=cssclass)
  Shared del_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("del", inner, style:=cssclass)
  Shared details_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("details", inner, style:=cssclass)
  Shared dfn_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("dfn", inner, style:=cssclass)
  Shared dir_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("dir", inner, style:=cssclass)
  Shared div_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("div", inner, style:=cssclass)
  Shared dl_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("dl", inner, style:=cssclass)
  Shared dt_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("dt", inner, style:=cssclass)
  Shared em_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("em", inner, style:=cssclass)
  Shared fieldset_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("fieldset", inner, style:=cssclass)
  Shared figcaption_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("figcaption", inner, style:=cssclass)
  Shared figure_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("figure", inner, style:=cssclass)
  Shared font_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("font", inner, style:=cssclass)
  Shared footer_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("footer", inner, style:=cssclass)
  Shared form_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("form", inner, style:=cssclass)
  Shared frame_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("frame", inner, style:=cssclass)
  Shared frameset_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("frameset", inner, style:=cssclass)
  Shared h1_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("h1", inner, style:=cssclass)
  Shared h2_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("h2", inner, style:=cssclass)
  Shared h3_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("h3", inner, style:=cssclass)
  Shared h4_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("h4", inner, style:=cssclass)
  Shared h5_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("h5", inner, style:=cssclass)
  Shared h6_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("h6", inner, style:=cssclass)
  Shared head_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("head", inner, style:=cssclass)
  Shared header_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("header", inner, style:=cssclass)
  Shared hgroup_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("hgroup", inner, style:=cssclass)
  Shared hr_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("hr", inner, style:=cssclass)
  Shared html_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("html", inner, style:=cssclass)
  Shared i_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("i", inner, style:=cssclass)
  Shared iframe_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("iframe", inner, style:=cssclass)
  Shared img_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("img", inner, style:=cssclass)
  Shared input_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("input", inner, style:=cssclass)
  Shared ins_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("ins", inner, style:=cssclass)
  Shared keygen_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("keygen", inner, style:=cssclass)
  Shared kbd_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("kbd", inner, style:=cssclass)
  Shared label_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("label", inner, style:=cssclass)
  Shared legend_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("legend", inner, style:=cssclass)
  Shared li_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("li", inner, style:=cssclass)
  Shared link_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("link", inner, style:=cssclass)
  Shared map_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("map", inner, style:=cssclass)
  Shared mark_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("mark", inner, style:=cssclass)
  Shared menu_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("menu", inner, style:=cssclass)
  Shared meta_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("meta", inner, style:=cssclass)
  Shared meter_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("meter", inner, style:=cssclass)
  Shared nav_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("nav", inner, style:=cssclass)
  Shared ol_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("ol", inner, style:=cssclass)
  Shared optgroup_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("optgroup", inner, style:=cssclass)
  Shared option_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("option", inner, style:=cssclass)
  Shared output_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("output", inner, style:=cssclass)
  Shared p_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("p", inner, style:=cssclass)
  Shared param_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("param", inner, style:=cssclass)
  Shared pre_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("pre", inner, style:=cssclass)
  Shared progress_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("progress", inner, style:=cssclass)
  Shared q_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("q", inner, style:=cssclass)
  Shared rp_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("rp", inner, style:=cssclass)
  Shared rt_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("rt", inner, style:=cssclass)
  Shared ruby_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("ruby", inner, style:=cssclass)
  Shared s_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("s", inner, style:=cssclass)
  Shared samp_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("samp", inner, style:=cssclass)
  Shared script_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("script", inner, style:=cssclass)
  Shared section_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("section", inner, style:=cssclass)
  Shared select_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("select", inner, style:=cssclass)
  Shared small_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("small", inner, style:=cssclass)
  Shared source_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("source", inner, style:=cssclass)
  Shared span_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("span", inner, style:=cssclass)
  Shared strike_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("strike", inner, style:=cssclass)
  Shared strong_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("strong", inner, style:=cssclass)
  Shared style_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("style", inner, style:=cssclass)
  Shared sub_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("sub", inner, style:=cssclass)
  Shared summary_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("summary", inner, style:=cssclass)
  Shared sup_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("sup", inner, style:=cssclass)
  Shared table_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("table", inner, style:=cssclass)
  Shared tbody_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("tbody", inner, style:=cssclass)
  Shared td_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("td", inner, style:=cssclass)
  Shared textarea_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("textarea", inner, style:=cssclass)
  Shared tfoot_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("tfoot", inner, style:=cssclass)
  Shared th_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("th", inner, style:=cssclass)
  Shared thead_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("thead", inner, style:=cssclass)
  Shared time_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("time", inner, style:=cssclass)
  Shared title_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("title", inner, style:=cssclass)
  Shared tr_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("tr", inner, style:=cssclass)
  Shared tt_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("tt", inner, style:=cssclass)
  Shared u_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("u", inner, style:=cssclass)
  Shared ul_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("ul", inner, style:=cssclass)
  Shared var_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("var", inner, style:=cssclass)
  Shared wbr_Class As Func(Of String, String, String) = Function(inner, cssclass) tag("wbr", inner, style:=cssclass)

  Shared a_ID As Func(Of String, String, String) = Function(inner, id) tag("a", inner, id:=id)
  Shared abbr_ID As Func(Of String, String, String) = Function(inner, id) tag("abbr", inner, id:=id)
  Shared acronym_ID As Func(Of String, String, String) = Function(inner, id) tag("acronym", inner, id:=id)
  Shared address_ID As Func(Of String, String, String) = Function(inner, id) tag("address", inner, id:=id)
  Shared applet_ID As Func(Of String, String, String) = Function(inner, id) tag("applet", inner, id:=id)
  Shared area_ID As Func(Of String, String, String) = Function(inner, id) tag("area", inner, id:=id)
  Shared article_ID As Func(Of String, String, String) = Function(inner, id) tag("article", inner, id:=id)
  Shared aside_ID As Func(Of String, String, String) = Function(inner, id) tag("aside", inner, id:=id)
  Shared b_ID As Func(Of String, String, String) = Function(inner, id) tag("b", inner, id:=id)
  Shared base_ID As Func(Of String, String, String) = Function(inner, id) tag("base", inner, id:=id)
  Shared basefont_ID As Func(Of String, String, String) = Function(inner, id) tag("basefont", inner, id:=id)
  Shared bdo_ID As Func(Of String, String, String) = Function(inner, id) tag("bdo", inner, id:=id)
  Shared big_ID As Func(Of String, String, String) = Function(inner, id) tag("big", inner, id:=id)
  Shared blockquote_ID As Func(Of String, String, String) = Function(inner, id) tag("blockquote", inner, id:=id)
  Shared body_ID As Func(Of String, String, String) = Function(inner, id) tag("body", inner, id:=id)
  Shared button_ID As Func(Of String, String, String) = Function(inner, id) tag("button", inner, id:=id)
  Shared canvas_ID As Func(Of String, String, String) = Function(inner, id) tag("canvas", inner, id:=id)
  Shared caption_ID As Func(Of String, String, String) = Function(inner, id) tag("caption", inner, id:=id)
  Shared center_ID As Func(Of String, String, String) = Function(inner, id) tag("center", inner, id:=id)
  Shared cite_ID As Func(Of String, String, String) = Function(inner, id) tag("cite", inner, id:=id)
  Shared code_ID As Func(Of String, String, String) = Function(inner, id) tag("code", inner, id:=id)
  Shared col_ID As Func(Of String, String, String) = Function(inner, id) tag("col", inner, id:=id)
  Shared colgroup_ID As Func(Of String, String, String) = Function(inner, id) tag("colgroup", inner, id:=id)
  Shared command_ID As Func(Of String, String, String) = Function(inner, id) tag("command", inner, id:=id)
  Shared datalist_ID As Func(Of String, String, String) = Function(inner, id) tag("datalist", inner, id:=id)
  Shared dd_ID As Func(Of String, String, String) = Function(inner, id) tag("dd", inner, id:=id)
  Shared del_ID As Func(Of String, String, String) = Function(inner, id) tag("del", inner, id:=id)
  Shared details_ID As Func(Of String, String, String) = Function(inner, id) tag("details", inner, id:=id)
  Shared dfn_ID As Func(Of String, String, String) = Function(inner, id) tag("dfn", inner, id:=id)
  Shared dir_ID As Func(Of String, String, String) = Function(inner, id) tag("dir", inner, id:=id)
  Shared div_ID As Func(Of String, String, String) = Function(inner, id) tag("div", inner, id:=id)
  Shared dl_ID As Func(Of String, String, String) = Function(inner, id) tag("dl", inner, id:=id)
  Shared dt_ID As Func(Of String, String, String) = Function(inner, id) tag("dt", inner, id:=id)
  Shared em_ID As Func(Of String, String, String) = Function(inner, id) tag("em", inner, id:=id)
  Shared fieldset_ID As Func(Of String, String, String) = Function(inner, id) tag("fieldset", inner, id:=id)
  Shared figcaption_ID As Func(Of String, String, String) = Function(inner, id) tag("figcaption", inner, id:=id)
  Shared figure_ID As Func(Of String, String, String) = Function(inner, id) tag("figure", inner, id:=id)
  Shared font_ID As Func(Of String, String, String) = Function(inner, id) tag("font", inner, id:=id)
  Shared footer_ID As Func(Of String, String, String) = Function(inner, id) tag("footer", inner, id:=id)
  Shared form_ID As Func(Of String, String, String) = Function(inner, id) tag("form", inner, id:=id)
  Shared frame_ID As Func(Of String, String, String) = Function(inner, id) tag("frame", inner, id:=id)
  Shared frameset_ID As Func(Of String, String, String) = Function(inner, id) tag("frameset", inner, id:=id)
  Shared h1_ID As Func(Of String, String, String) = Function(inner, id) tag("h1", inner, id:=id)
  Shared h2_ID As Func(Of String, String, String) = Function(inner, id) tag("h2", inner, id:=id)
  Shared h3_ID As Func(Of String, String, String) = Function(inner, id) tag("h3", inner, id:=id)
  Shared h4_ID As Func(Of String, String, String) = Function(inner, id) tag("h4", inner, id:=id)
  Shared h5_ID As Func(Of String, String, String) = Function(inner, id) tag("h5", inner, id:=id)
  Shared h6_ID As Func(Of String, String, String) = Function(inner, id) tag("h6", inner, id:=id)
  Shared head_ID As Func(Of String, String, String) = Function(inner, id) tag("head", inner, id:=id)
  Shared header_ID As Func(Of String, String, String) = Function(inner, id) tag("header", inner, id:=id)
  Shared hgroup_ID As Func(Of String, String, String) = Function(inner, id) tag("hgroup", inner, id:=id)
  Shared hr_ID As Func(Of String, String, String) = Function(inner, id) tag("hr", inner, id:=id)
  Shared html_ID As Func(Of String, String, String) = Function(inner, id) tag("html", inner, id:=id)
  Shared i_ID As Func(Of String, String, String) = Function(inner, id) tag("i", inner, id:=id)
  Shared iframe_ID As Func(Of String, String, String) = Function(inner, id) tag("iframe", inner, id:=id)
  Shared img_ID As Func(Of String, String, String) = Function(inner, id) tag("img", inner, id:=id)
  Shared input_ID As Func(Of String, String, String) = Function(inner, id) tag("input", inner, id:=id)
  Shared ins_ID As Func(Of String, String, String) = Function(inner, id) tag("ins", inner, id:=id)
  Shared keygen_ID As Func(Of String, String, String) = Function(inner, id) tag("keygen", inner, id:=id)
  Shared kbd_ID As Func(Of String, String, String) = Function(inner, id) tag("kbd", inner, id:=id)
  Shared label_ID As Func(Of String, String, String) = Function(inner, id) tag("label", inner, id:=id)
  Shared legend_ID As Func(Of String, String, String) = Function(inner, id) tag("legend", inner, id:=id)
  Shared li_ID As Func(Of String, String, String) = Function(inner, id) tag("li", inner, id:=id)
  Shared link_ID As Func(Of String, String, String) = Function(inner, id) tag("link", inner, id:=id)
  Shared map_ID As Func(Of String, String, String) = Function(inner, id) tag("map", inner, id:=id)
  Shared mark_ID As Func(Of String, String, String) = Function(inner, id) tag("mark", inner, id:=id)
  Shared menu_ID As Func(Of String, String, String) = Function(inner, id) tag("menu", inner, id:=id)
  Shared meta_ID As Func(Of String, String, String) = Function(inner, id) tag("meta", inner, id:=id)
  Shared meter_ID As Func(Of String, String, String) = Function(inner, id) tag("meter", inner, id:=id)
  Shared nav_ID As Func(Of String, String, String) = Function(inner, id) tag("nav", inner, id:=id)
  Shared ol_ID As Func(Of String, String, String) = Function(inner, id) tag("ol", inner, id:=id)
  Shared optgroup_ID As Func(Of String, String, String) = Function(inner, id) tag("optgroup", inner, id:=id)
  Shared option_ID As Func(Of String, String, String) = Function(inner, id) tag("option", inner, id:=id)
  Shared output_ID As Func(Of String, String, String) = Function(inner, id) tag("output", inner, id:=id)
  Shared p_ID As Func(Of String, String, String) = Function(inner, id) tag("p", inner, id:=id)
  Shared param_ID As Func(Of String, String, String) = Function(inner, id) tag("param", inner, id:=id)
  Shared pre_ID As Func(Of String, String, String) = Function(inner, id) tag("pre", inner, id:=id)
  Shared progress_ID As Func(Of String, String, String) = Function(inner, id) tag("progress", inner, id:=id)
  Shared q_ID As Func(Of String, String, String) = Function(inner, id) tag("q", inner, id:=id)
  Shared rp_ID As Func(Of String, String, String) = Function(inner, id) tag("rp", inner, id:=id)
  Shared rt_ID As Func(Of String, String, String) = Function(inner, id) tag("rt", inner, id:=id)
  Shared ruby_ID As Func(Of String, String, String) = Function(inner, id) tag("ruby", inner, id:=id)
  Shared s_ID As Func(Of String, String, String) = Function(inner, id) tag("s", inner, id:=id)
  Shared samp_ID As Func(Of String, String, String) = Function(inner, id) tag("samp", inner, id:=id)
  Shared script_ID As Func(Of String, String, String) = Function(inner, id) tag("script", inner, id:=id)
  Shared section_ID As Func(Of String, String, String) = Function(inner, id) tag("section", inner, id:=id)
  Shared select_ID As Func(Of String, String, String) = Function(inner, id) tag("select", inner, id:=id)
  Shared small_ID As Func(Of String, String, String) = Function(inner, id) tag("small", inner, id:=id)
  Shared source_ID As Func(Of String, String, String) = Function(inner, id) tag("source", inner, id:=id)
  Shared span_ID As Func(Of String, String, String) = Function(inner, id) tag("span", inner, id:=id)
  Shared strike_ID As Func(Of String, String, String) = Function(inner, id) tag("strike", inner, id:=id)
  Shared strong_ID As Func(Of String, String, String) = Function(inner, id) tag("strong", inner, id:=id)
  Shared style_ID As Func(Of String, String, String) = Function(inner, id) tag("style", inner, id:=id)
  Shared sub_ID As Func(Of String, String, String) = Function(inner, id) tag("sub", inner, id:=id)
  Shared summary_ID As Func(Of String, String, String) = Function(inner, id) tag("summary", inner, id:=id)
  Shared sup_ID As Func(Of String, String, String) = Function(inner, id) tag("sup", inner, id:=id)
  Shared table_ID As Func(Of String, String, String) = Function(inner, id) tag("table", inner, id:=id)
  Shared tbody_ID As Func(Of String, String, String) = Function(inner, id) tag("tbody", inner, id:=id)
  Shared td_ID As Func(Of String, String, String) = Function(inner, id) tag("td", inner, id:=id)
  Shared textarea_ID As Func(Of String, String, String) = Function(inner, id) tag("textarea", inner, id:=id)
  Shared tfoot_ID As Func(Of String, String, String) = Function(inner, id) tag("tfoot", inner, id:=id)
  Shared th_ID As Func(Of String, String, String) = Function(inner, id) tag("th", inner, id:=id)
  Shared thead_ID As Func(Of String, String, String) = Function(inner, id) tag("thead", inner, id:=id)
  Shared time_ID As Func(Of String, String, String) = Function(inner, id) tag("time", inner, id:=id)
  Shared title_ID As Func(Of String, String, String) = Function(inner, id) tag("title", inner, id:=id)
  Shared tr_ID As Func(Of String, String, String) = Function(inner, id) tag("tr", inner, id:=id)
  Shared tt_ID As Func(Of String, String, String) = Function(inner, id) tag("tt", inner, id:=id)
  Shared u_ID As Func(Of String, String, String) = Function(inner, id) tag("u", inner, id:=id)
  Shared ul_ID As Func(Of String, String, String) = Function(inner, id) tag("ul", inner, id:=id)
  Shared var_ID As Func(Of String, String, String) = Function(inner, id) tag("var", inner, id:=id)
  Shared wbr_ID As Func(Of String, String, String) = Function(inner, id) tag("wbr", inner, id:=id)

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

  Shared Function a(ByVal inner As String) As String
    Return a_Generic(inner)
  End Function
  Shared Function a(ByVal inner As String, ByVal id As String) As String
    Return a_ID(inner, id)
  End Function
  Shared Function a(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return a_ID_Class(inner, id, cssclass)
  End Function
  Shared Function abbr(ByVal inner As String) As String
    Return abbr_Generic(inner)
  End Function
  Shared Function abbr(ByVal inner As String, ByVal id As String) As String
    Return abbr_ID(inner, id)
  End Function
  Shared Function abbr(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return abbr_ID_Class(inner, id, cssclass)
  End Function
  Shared Function acronym(ByVal inner As String) As String
    Return acronym_Generic(inner)
  End Function
  Shared Function acronym(ByVal inner As String, ByVal id As String) As String
    Return acronym_ID(inner, id)
  End Function
  Shared Function acronym(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return acronym_ID_Class(inner, id, cssclass)
  End Function
  Shared Function address(ByVal inner As String) As String
    Return address_Generic(inner)
  End Function
  Shared Function address(ByVal inner As String, ByVal id As String) As String
    Return address_ID(inner, id)
  End Function
  Shared Function address(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return address_ID_Class(inner, id, cssclass)
  End Function
  Shared Function applet(ByVal inner As String) As String
    Return applet_Generic(inner)
  End Function
  Shared Function applet(ByVal inner As String, ByVal id As String) As String
    Return applet_ID(inner, id)
  End Function
  Shared Function applet(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return applet_ID_Class(inner, id, cssclass)
  End Function
  Shared Function area(ByVal inner As String) As String
    Return area_Generic(inner)
  End Function
  Shared Function area(ByVal inner As String, ByVal id As String) As String
    Return area_ID(inner, id)
  End Function
  Shared Function area(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return area_ID_Class(inner, id, cssclass)
  End Function
  Shared Function article(ByVal inner As String) As String
    Return article_Generic(inner)
  End Function
  Shared Function article(ByVal inner As String, ByVal id As String) As String
    Return article_ID(inner, id)
  End Function
  Shared Function article(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return article_ID_Class(inner, id, cssclass)
  End Function
  Shared Function aside(ByVal inner As String) As String
    Return aside_Generic(inner)
  End Function
  Shared Function aside(ByVal inner As String, ByVal id As String) As String
    Return aside_ID(inner, id)
  End Function
  Shared Function aside(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return aside_ID_Class(inner, id, cssclass)
  End Function
  Shared Function b(ByVal inner As String) As String
    Return b_Generic(inner)
  End Function
  Shared Function b(ByVal inner As String, ByVal id As String) As String
    Return b_ID(inner, id)
  End Function
  Shared Function b(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return b_ID_Class(inner, id, cssclass)
  End Function
  Shared Function base(ByVal inner As String) As String
    Return base_Generic(inner)
  End Function
  Shared Function base(ByVal inner As String, ByVal id As String) As String
    Return base_ID(inner, id)
  End Function
  Shared Function base(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return base_ID_Class(inner, id, cssclass)
  End Function
  Shared Function basefont(ByVal inner As String) As String
    Return basefont_Generic(inner)
  End Function
  Shared Function basefont(ByVal inner As String, ByVal id As String) As String
    Return basefont_ID(inner, id)
  End Function
  Shared Function basefont(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return basefont_ID_Class(inner, id, cssclass)
  End Function
  Shared Function bdo(ByVal inner As String) As String
    Return bdo_Generic(inner)
  End Function
  Shared Function bdo(ByVal inner As String, ByVal id As String) As String
    Return bdo_ID(inner, id)
  End Function
  Shared Function bdo(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return bdo_ID_Class(inner, id, cssclass)
  End Function
  Shared Function big(ByVal inner As String) As String
    Return big_Generic(inner)
  End Function
  Shared Function big(ByVal inner As String, ByVal id As String) As String
    Return big_ID(inner, id)
  End Function
  Shared Function big(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return big_ID_Class(inner, id, cssclass)
  End Function
  Shared Function blockquote(ByVal inner As String) As String
    Return blockquote_Generic(inner)
  End Function
  Shared Function blockquote(ByVal inner As String, ByVal id As String) As String
    Return blockquote_ID(inner, id)
  End Function
  Shared Function blockquote(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return blockquote_ID_Class(inner, id, cssclass)
  End Function
  Shared Function body(ByVal inner As String) As String
    Return body_Generic(inner)
  End Function
  Shared Function body(ByVal inner As String, ByVal id As String) As String
    Return body_ID(inner, id)
  End Function
  Shared Function body(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return body_ID_Class(inner, id, cssclass)
  End Function
  Shared Function br() As String
    Return "<br />"
  End Function

  Shared Function button(ByVal inner As String) As String
    Return button_Generic(inner)
  End Function
  Shared Function button(ByVal inner As String, ByVal id As String) As String
    Return button_ID(inner, id)
  End Function
  Shared Function button(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return button_ID_Class(inner, id, cssclass)
  End Function
  Shared Function canvas(ByVal inner As String) As String
    Return canvas_Generic(inner)
  End Function
  Shared Function canvas(ByVal inner As String, ByVal id As String) As String
    Return canvas_ID(inner, id)
  End Function
  Shared Function canvas(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return canvas_ID_Class(inner, id, cssclass)
  End Function
  Shared Function caption(ByVal inner As String) As String
    Return caption_Generic(inner)
  End Function
  Shared Function caption(ByVal inner As String, ByVal id As String) As String
    Return caption_ID(inner, id)
  End Function
  Shared Function caption(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return caption_ID_Class(inner, id, cssclass)
  End Function
  Shared Function center(ByVal inner As String) As String
    Return center_Generic(inner)
  End Function
  Shared Function center(ByVal inner As String, ByVal id As String) As String
    Return center_ID(inner, id)
  End Function
  Shared Function center(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return center_ID_Class(inner, id, cssclass)
  End Function
  Shared Function cite(ByVal inner As String) As String
    Return cite_Generic(inner)
  End Function
  Shared Function cite(ByVal inner As String, ByVal id As String) As String
    Return cite_ID(inner, id)
  End Function
  Shared Function cite(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return cite_ID_Class(inner, id, cssclass)
  End Function
  Shared Function code(ByVal inner As String) As String
    Return code_Generic(inner)
  End Function
  Shared Function code(ByVal inner As String, ByVal id As String) As String
    Return code_ID(inner, id)
  End Function
  Shared Function code(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return code_ID_Class(inner, id, cssclass)
  End Function
  Shared Function col(ByVal inner As String) As String
    Return col_Generic(inner)
  End Function
  Shared Function col(ByVal inner As String, ByVal id As String) As String
    Return col_ID(inner, id)
  End Function
  Shared Function col(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return col_ID_Class(inner, id, cssclass)
  End Function
  Shared Function colgroup(ByVal inner As String) As String
    Return colgroup_Generic(inner)
  End Function
  Shared Function colgroup(ByVal inner As String, ByVal id As String) As String
    Return colgroup_ID(inner, id)
  End Function
  Shared Function colgroup(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return colgroup_ID_Class(inner, id, cssclass)
  End Function
  Shared Function command(ByVal inner As String) As String
    Return command_Generic(inner)
  End Function
  Shared Function command(ByVal inner As String, ByVal id As String) As String
    Return command_ID(inner, id)
  End Function
  Shared Function command(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return command_ID_Class(inner, id, cssclass)
  End Function
  Shared Function datalist(ByVal inner As String) As String
    Return datalist_Generic(inner)
  End Function
  Shared Function datalist(ByVal inner As String, ByVal id As String) As String
    Return datalist_ID(inner, id)
  End Function
  Shared Function datalist(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return datalist_ID_Class(inner, id, cssclass)
  End Function
  Shared Function dd(ByVal inner As String) As String
    Return dd_Generic(inner)
  End Function
  Shared Function dd(ByVal inner As String, ByVal id As String) As String
    Return dd_ID(inner, id)
  End Function
  Shared Function dd(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return dd_ID_Class(inner, id, cssclass)
  End Function
  Shared Function del(ByVal inner As String) As String
    Return del_Generic(inner)
  End Function
  Shared Function del(ByVal inner As String, ByVal id As String) As String
    Return del_ID(inner, id)
  End Function
  Shared Function del(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return del_ID_Class(inner, id, cssclass)
  End Function
  Shared Function details(ByVal inner As String) As String
    Return details_Generic(inner)
  End Function
  Shared Function details(ByVal inner As String, ByVal id As String) As String
    Return details_ID(inner, id)
  End Function
  Shared Function details(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return details_ID_Class(inner, id, cssclass)
  End Function
  Shared Function dfn(ByVal inner As String) As String
    Return dfn_Generic(inner)
  End Function
  Shared Function dfn(ByVal inner As String, ByVal id As String) As String
    Return dfn_ID(inner, id)
  End Function
  Shared Function dfn(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return dfn_ID_Class(inner, id, cssclass)
  End Function
  Shared Function dir(ByVal inner As String) As String
    Return dir_Generic(inner)
  End Function
  Shared Function dir(ByVal inner As String, ByVal id As String) As String
    Return dir_ID(inner, id)
  End Function
  Shared Function dir(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return dir_ID_Class(inner, id, cssclass)
  End Function
  Shared Function div(ByVal inner As String) As String
    Return div_Generic(inner)
  End Function
  Shared Function div(ByVal inner As String, ByVal id As String) As String
    Return div_ID(inner, id)
  End Function
  Shared Function div(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return div_ID_Class(inner, id, cssclass)
  End Function
  Shared Function dl(ByVal inner As String) As String
    Return dl_Generic(inner)
  End Function
  Shared Function dl(ByVal inner As String, ByVal id As String) As String
    Return dl_ID(inner, id)
  End Function
  Shared Function dl(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return dl_ID_Class(inner, id, cssclass)
  End Function
  Shared Function dt(ByVal inner As String) As String
    Return dt_Generic(inner)
  End Function
  Shared Function dt(ByVal inner As String, ByVal id As String) As String
    Return dt_ID(inner, id)
  End Function
  Shared Function dt(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return dt_ID_Class(inner, id, cssclass)
  End Function
  Shared Function em(ByVal inner As String) As String
    Return em_Generic(inner)
  End Function
  Shared Function em(ByVal inner As String, ByVal id As String) As String
    Return em_ID(inner, id)
  End Function
  Shared Function em(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return em_ID_Class(inner, id, cssclass)
  End Function
  Shared Function fieldset(ByVal inner As String) As String
    Return fieldset_Generic(inner)
  End Function
  Shared Function fieldset(ByVal inner As String, ByVal id As String) As String
    Return fieldset_ID(inner, id)
  End Function
  Shared Function fieldset(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return fieldset_ID_Class(inner, id, cssclass)
  End Function
  Shared Function figcaption(ByVal inner As String) As String
    Return figcaption_Generic(inner)
  End Function
  Shared Function figcaption(ByVal inner As String, ByVal id As String) As String
    Return figcaption_ID(inner, id)
  End Function
  Shared Function figcaption(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return figcaption_ID_Class(inner, id, cssclass)
  End Function
  Shared Function figure(ByVal inner As String) As String
    Return figure_Generic(inner)
  End Function
  Shared Function figure(ByVal inner As String, ByVal id As String) As String
    Return figure_ID(inner, id)
  End Function
  Shared Function figure(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return figure_ID_Class(inner, id, cssclass)
  End Function
  Shared Function font(ByVal inner As String) As String
    Return font_Generic(inner)
  End Function
  Shared Function font(ByVal inner As String, ByVal id As String) As String
    Return font_ID(inner, id)
  End Function
  Shared Function font(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return font_ID_Class(inner, id, cssclass)
  End Function
  Shared Function footer(ByVal inner As String) As String
    Return footer_Generic(inner)
  End Function
  Shared Function footer(ByVal inner As String, ByVal id As String) As String
    Return footer_ID(inner, id)
  End Function
  Shared Function footer(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return footer_ID_Class(inner, id, cssclass)
  End Function
  Shared Function form(ByVal inner As String) As String
    Return form_Generic(inner)
  End Function
  Shared Function form(ByVal inner As String, ByVal id As String) As String
    Return form_ID(inner, id)
  End Function
  Shared Function form(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return form_ID_Class(inner, id, cssclass)
  End Function
  Shared Function frame(ByVal inner As String) As String
    Return frame_Generic(inner)
  End Function
  Shared Function frame(ByVal inner As String, ByVal id As String) As String
    Return frame_ID(inner, id)
  End Function
  Shared Function frame(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return frame_ID_Class(inner, id, cssclass)
  End Function
  Shared Function frameset(ByVal inner As String) As String
    Return frameset_Generic(inner)
  End Function
  Shared Function frameset(ByVal inner As String, ByVal id As String) As String
    Return frameset_ID(inner, id)
  End Function
  Shared Function frameset(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return frameset_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h1(ByVal inner As String) As String
    Return h1_Generic(inner)
  End Function
  Shared Function h1(ByVal inner As String, ByVal id As String) As String
    Return h1_ID(inner, id)
  End Function
  Shared Function h1(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return h1_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h2(ByVal inner As String) As String
    Return h2_Generic(inner)
  End Function
  Shared Function h2(ByVal inner As String, ByVal id As String) As String
    Return h2_ID(inner, id)
  End Function
  Shared Function h2(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return h2_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h3(ByVal inner As String) As String
    Return h3_Generic(inner)
  End Function
  Shared Function h3(ByVal inner As String, ByVal id As String) As String
    Return h3_ID(inner, id)
  End Function
  Shared Function h3(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return h3_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h4(ByVal inner As String) As String
    Return h4_Generic(inner)
  End Function
  Shared Function h4(ByVal inner As String, ByVal id As String) As String
    Return h4_ID(inner, id)
  End Function
  Shared Function h4(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return h4_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h5(ByVal inner As String) As String
    Return h5_Generic(inner)
  End Function
  Shared Function h5(ByVal inner As String, ByVal id As String) As String
    Return h5_ID(inner, id)
  End Function
  Shared Function h5(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return h5_ID_Class(inner, id, cssclass)
  End Function
  Shared Function h6(ByVal inner As String) As String
    Return h6_Generic(inner)
  End Function
  Shared Function h6(ByVal inner As String, ByVal id As String) As String
    Return h6_ID(inner, id)
  End Function
  Shared Function h6(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return h6_ID_Class(inner, id, cssclass)
  End Function
  Shared Function head(ByVal inner As String) As String
    Return head_Generic(inner)
  End Function
  Shared Function head(ByVal inner As String, ByVal id As String) As String
    Return head_ID(inner, id)
  End Function
  Shared Function head(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return head_ID_Class(inner, id, cssclass)
  End Function
  Shared Function header(ByVal inner As String) As String
    Return header_Generic(inner)
  End Function
  Shared Function header(ByVal inner As String, ByVal id As String) As String
    Return header_ID(inner, id)
  End Function
  Shared Function header(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return header_ID_Class(inner, id, cssclass)
  End Function
  Shared Function hgroup(ByVal inner As String) As String
    Return hgroup_Generic(inner)
  End Function
  Shared Function hgroup(ByVal inner As String, ByVal id As String) As String
    Return hgroup_ID(inner, id)
  End Function
  Shared Function hgroup(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return hgroup_ID_Class(inner, id, cssclass)
  End Function
  Shared Function hr(ByVal inner As String) As String
    Return hr_Generic(inner)
  End Function
  Shared Function hr(ByVal inner As String, ByVal id As String) As String
    Return hr_ID(inner, id)
  End Function
  Shared Function hr(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return hr_ID_Class(inner, id, cssclass)
  End Function
  Shared Function html(ByVal inner As String) As String
    Return html_Generic(inner)
  End Function
  Shared Function html(ByVal inner As String, ByVal id As String) As String
    Return html_ID(inner, id)
  End Function
  Shared Function html(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return html_ID_Class(inner, id, cssclass)
  End Function
  Shared Function i(ByVal inner As String) As String
    Return i_Generic(inner)
  End Function
  Shared Function i(ByVal inner As String, ByVal id As String) As String
    Return i_ID(inner, id)
  End Function
  Shared Function i(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return i_ID_Class(inner, id, cssclass)
  End Function
  Shared Function iframe(ByVal inner As String) As String
    Return iframe_Generic(inner)
  End Function
  Shared Function iframe(ByVal inner As String, ByVal id As String) As String
    Return iframe_ID(inner, id)
  End Function
  Shared Function iframe(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return iframe_ID_Class(inner, id, cssclass)
  End Function
  Shared Function img(ByVal inner As String) As String
    Return img_Generic(inner)
  End Function
  Shared Function img(ByVal inner As String, ByVal id As String) As String
    Return img_ID(inner, id)
  End Function
  Shared Function img(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return img_ID_Class(inner, id, cssclass)
  End Function
  Shared Function input(ByVal inner As String) As String
    Return input_Generic(inner)
  End Function
  Shared Function input(ByVal inner As String, ByVal id As String) As String
    Return input_ID(inner, id)
  End Function
  Shared Function input(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return input_ID_Class(inner, id, cssclass)
  End Function
  Shared Function ins(ByVal inner As String) As String
    Return ins_Generic(inner)
  End Function
  Shared Function ins(ByVal inner As String, ByVal id As String) As String
    Return ins_ID(inner, id)
  End Function
  Shared Function ins(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return ins_ID_Class(inner, id, cssclass)
  End Function
  Shared Function keygen(ByVal inner As String) As String
    Return keygen_Generic(inner)
  End Function
  Shared Function keygen(ByVal inner As String, ByVal id As String) As String
    Return keygen_ID(inner, id)
  End Function
  Shared Function keygen(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return keygen_ID_Class(inner, id, cssclass)
  End Function
  Shared Function kbd(ByVal inner As String) As String
    Return kbd_Generic(inner)
  End Function
  Shared Function kbd(ByVal inner As String, ByVal id As String) As String
    Return kbd_ID(inner, id)
  End Function
  Shared Function kbd(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return kbd_ID_Class(inner, id, cssclass)
  End Function
  Shared Function label(ByVal inner As String) As String
    Return label_Generic(inner)
  End Function
  Shared Function label(ByVal inner As String, ByVal id As String) As String
    Return label_ID(inner, id)
  End Function
  Shared Function label(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return label_ID_Class(inner, id, cssclass)
  End Function
  Shared Function legend(ByVal inner As String) As String
    Return legend_Generic(inner)
  End Function
  Shared Function legend(ByVal inner As String, ByVal id As String) As String
    Return legend_ID(inner, id)
  End Function
  Shared Function legend(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return legend_ID_Class(inner, id, cssclass)
  End Function
  Shared Function li(ByVal inner As String) As String
    Return li_Generic(inner)
  End Function
  Shared Function li(ByVal inner As String, ByVal id As String) As String
    Return li_ID(inner, id)
  End Function
  Shared Function li(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return li_ID_Class(inner, id, cssclass)
  End Function

  Shared Function map(ByVal inner As String) As String
    Return map_Generic(inner)
  End Function
  Shared Function map(ByVal inner As String, ByVal id As String) As String
    Return map_ID(inner, id)
  End Function
  Shared Function map(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return map_ID_Class(inner, id, cssclass)
  End Function
  Shared Function mark(ByVal inner As String) As String
    Return mark_Generic(inner)
  End Function
  Shared Function mark(ByVal inner As String, ByVal id As String) As String
    Return mark_ID(inner, id)
  End Function
  Shared Function mark(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return mark_ID_Class(inner, id, cssclass)
  End Function
  Shared Function menu(ByVal inner As String) As String
    Return menu_Generic(inner)
  End Function
  Shared Function menu(ByVal inner As String, ByVal id As String) As String
    Return menu_ID(inner, id)
  End Function
  Shared Function menu(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return menu_ID_Class(inner, id, cssclass)
  End Function
  Shared Function meta(ByVal inner As String) As String
    Return meta_Generic(inner)
  End Function
  Shared Function meta(ByVal inner As String, ByVal id As String) As String
    Return meta_ID(inner, id)
  End Function
  Shared Function meta(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return meta_ID_Class(inner, id, cssclass)
  End Function
  Shared Function meter(ByVal inner As String) As String
    Return meter_Generic(inner)
  End Function
  Shared Function meter(ByVal inner As String, ByVal id As String) As String
    Return meter_ID(inner, id)
  End Function
  Shared Function meter(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return meter_ID_Class(inner, id, cssclass)
  End Function
  Shared Function nav(ByVal inner As String) As String
    Return nav_Generic(inner)
  End Function
  Shared Function nav(ByVal inner As String, ByVal id As String) As String
    Return nav_ID(inner, id)
  End Function
  Shared Function nav(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return nav_ID_Class(inner, id, cssclass)
  End Function
  Shared Function ol(ByVal inner As String) As String
    Return ol_Generic(inner)
  End Function
  Shared Function ol(ByVal inner As String, ByVal id As String) As String
    Return ol_ID(inner, id)
  End Function
  Shared Function ol(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return ol_ID_Class(inner, id, cssclass)
  End Function
  Shared Function optgroup(ByVal inner As String) As String
    Return optgroup_Generic(inner)
  End Function
  Shared Function optgroup(ByVal inner As String, ByVal id As String) As String
    Return optgroup_ID(inner, id)
  End Function
  Shared Function optgroup(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return optgroup_ID_Class(inner, id, cssclass)
  End Function
  Shared Function output(ByVal inner As String) As String
    Return output_Generic(inner)
  End Function
  Shared Function output(ByVal inner As String, ByVal id As String) As String
    Return output_ID(inner, id)
  End Function








  Shared Function output(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return output_ID_Class(inner, id, cssclass)
  End Function
  Shared Function p(ByVal inner As String) As String
    Return p_Generic(inner)
  End Function
  Shared Function p(ByVal inner As String, ByVal id As String) As String
    Return p_ID(inner, id)
  End Function
  Shared Function p(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return p_ID_Class(inner, id, cssclass)
  End Function
  Shared Function param(ByVal inner As String) As String
    Return param_Generic(inner)
  End Function
  Shared Function param(ByVal inner As String, ByVal id As String) As String
    Return param_ID(inner, id)
  End Function
  Shared Function param(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return param_ID_Class(inner, id, cssclass)
  End Function
  Shared Function pre(ByVal inner As String) As String
    Return pre_Generic(inner)
  End Function
  Shared Function pre(ByVal inner As String, ByVal id As String) As String
    Return pre_ID(inner, id)
  End Function
  Shared Function pre(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return pre_ID_Class(inner, id, cssclass)
  End Function
  Shared Function progress(ByVal inner As String) As String
    Return progress_Generic(inner)
  End Function
  Shared Function progress(ByVal inner As String, ByVal id As String) As String
    Return progress_ID(inner, id)
  End Function
  Shared Function progress(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return progress_ID_Class(inner, id, cssclass)
  End Function
  Shared Function q(ByVal inner As String) As String
    Return q_Generic(inner)
  End Function
  Shared Function q(ByVal inner As String, ByVal id As String) As String
    Return q_ID(inner, id)
  End Function
  Shared Function q(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return q_ID_Class(inner, id, cssclass)
  End Function
  Shared Function rp(ByVal inner As String) As String
    Return rp_Generic(inner)
  End Function
  Shared Function rp(ByVal inner As String, ByVal id As String) As String
    Return rp_ID(inner, id)
  End Function
  Shared Function rp(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return rp_ID_Class(inner, id, cssclass)
  End Function
  Shared Function rt(ByVal inner As String) As String
    Return rt_Generic(inner)
  End Function
  Shared Function rt(ByVal inner As String, ByVal id As String) As String
    Return rt_ID(inner, id)
  End Function
  Shared Function rt(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return rt_ID_Class(inner, id, cssclass)
  End Function
  Shared Function ruby(ByVal inner As String) As String
    Return ruby_Generic(inner)
  End Function
  Shared Function ruby(ByVal inner As String, ByVal id As String) As String
    Return ruby_ID(inner, id)
  End Function
  Shared Function ruby(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return ruby_ID_Class(inner, id, cssclass)
  End Function
  Shared Function s(ByVal inner As String) As String
    Return s_Generic(inner)
  End Function
  Shared Function s(ByVal inner As String, ByVal id As String) As String
    Return s_ID(inner, id)
  End Function
  Shared Function s(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return s_ID_Class(inner, id, cssclass)
  End Function
  Shared Function samp(ByVal inner As String) As String
    Return samp_Generic(inner)
  End Function
  Shared Function samp(ByVal inner As String, ByVal id As String) As String
    Return samp_ID(inner, id)
  End Function
  Shared Function samp(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return samp_ID_Class(inner, id, cssclass)
  End Function
  Shared Function script(ByVal inner As String) As String
    Return script_Generic(inner)
  End Function
  Shared Function script(ByVal inner As String, ByVal id As String) As String
    Return script_ID(inner, id)
  End Function
  Shared Function script(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return script_ID_Class(inner, id, cssclass)
  End Function
  Shared Function section(ByVal inner As String) As String
    Return section_Generic(inner)
  End Function
  Shared Function section(ByVal inner As String, ByVal id As String) As String
    Return section_ID(inner, id)
  End Function
  Shared Function section(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return section_ID_Class(inner, id, cssclass)
  End Function

  Shared Function small(ByVal inner As String) As String
    Return small_Generic(inner)
  End Function
  Shared Function small(ByVal inner As String, ByVal id As String) As String
    Return small_ID(inner, id)
  End Function
  Shared Function small(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return small_ID_Class(inner, id, cssclass)
  End Function
  Shared Function source(ByVal inner As String) As String
    Return source_Generic(inner)
  End Function
  Shared Function source(ByVal inner As String, ByVal id As String) As String
    Return source_ID(inner, id)
  End Function
  Shared Function source(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return source_ID_Class(inner, id, cssclass)
  End Function
  Shared Function span(ByVal inner As String) As String
    Return span_Generic(inner)
  End Function
  Shared Function span(ByVal inner As String, ByVal id As String) As String
    Return span_ID(inner, id)
  End Function
  Shared Function span(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return span_ID_Class(inner, id, cssclass)
  End Function
  Shared Function strike(ByVal inner As String) As String
    Return strike_Generic(inner)
  End Function
  Shared Function strike(ByVal inner As String, ByVal id As String) As String
    Return strike_ID(inner, id)
  End Function
  Shared Function strike(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return strike_ID_Class(inner, id, cssclass)
  End Function
  Shared Function strong(ByVal inner As String) As String
    Return strong_Generic(inner)
  End Function
  Shared Function strong(ByVal inner As String, ByVal id As String) As String
    Return strong_ID(inner, id)
  End Function
  Shared Function strong(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return strong_ID_Class(inner, id, cssclass)
  End Function
  Shared Function style(ByVal inner As String) As String
    Return style_Generic(inner)
  End Function
  Shared Function style(ByVal inner As String, ByVal id As String) As String
    Return style_ID(inner, id)
  End Function
  Shared Function style(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return style_ID_Class(inner, id, cssclass)
  End Function
  Shared Function summary(ByVal inner As String) As String
    Return summary_Generic(inner)
  End Function
  Shared Function summary(ByVal inner As String, ByVal id As String) As String
    Return summary_ID(inner, id)
  End Function
  Shared Function summary(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return summary_ID_Class(inner, id, cssclass)
  End Function
  Shared Function sup(ByVal inner As String) As String
    Return sup_Generic(inner)
  End Function
  Shared Function sup(ByVal inner As String, ByVal id As String) As String
    Return sup_ID(inner, id)
  End Function
  Shared Function sup(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return sup_ID_Class(inner, id, cssclass)
  End Function
  Shared Function table(ByVal inner As String) As String
    Return table_Generic(inner)
  End Function
  Shared Function table(ByVal inner As String, ByVal id As String) As String
    Return table_ID(inner, id)
  End Function
  Shared Function table(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return table_ID_Class(inner, id, cssclass)
  End Function
  Shared Function tbody(ByVal inner As String) As String
    Return tbody_Generic(inner)
  End Function
  Shared Function tbody(ByVal inner As String, ByVal id As String) As String
    Return tbody_ID(inner, id)
  End Function
  Shared Function tbody(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return tbody_ID_Class(inner, id, cssclass)
  End Function
  Shared Function textarea(ByVal inner As String) As String
    Return textarea_Generic(inner)
  End Function
  Shared Function textarea(ByVal inner As String, ByVal id As String) As String
    Return textarea_ID(inner, id)
  End Function
  Shared Function textarea(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return textarea_ID_Class(inner, id, cssclass)
  End Function
  Shared Function tfoot(ByVal inner As String) As String
    Return tfoot_Generic(inner)
  End Function
  Shared Function tfoot(ByVal inner As String, ByVal id As String) As String
    Return tfoot_ID(inner, id)
  End Function
  Shared Function tfoot(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return tfoot_ID_Class(inner, id, cssclass)
  End Function
  Shared Function thead(ByVal inner As String) As String
    Return thead_Generic(inner)
  End Function
  Shared Function thead(ByVal inner As String, ByVal id As String) As String
    Return thead_ID(inner, id)
  End Function
  Shared Function thead(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return thead_ID_Class(inner, id, cssclass)
  End Function
  Shared Function time(ByVal inner As String) As String
    Return time_Generic(inner)
  End Function
  Shared Function time(ByVal inner As String, ByVal id As String) As String
    Return time_ID(inner, id)
  End Function
  Shared Function time(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return time_ID_Class(inner, id, cssclass)
  End Function
  Shared Function title(ByVal inner As String) As String
    Return title_Generic(inner)
  End Function
  Shared Function title(ByVal inner As String, ByVal id As String) As String
    Return title_ID(inner, id)
  End Function
  Shared Function title(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return title_ID_Class(inner, id, cssclass)
  End Function
  Shared Function tr(ByVal inner As String) As String
    Return tr_Generic(inner)
  End Function
  Shared Function tr(ByVal inner As String, ByVal id As String) As String
    Return tr_ID(inner, id)
  End Function
  Shared Function tr(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return tr_ID_Class(inner, id, cssclass)
  End Function
  Shared Function tt(ByVal inner As String) As String
    Return tt_Generic(inner)
  End Function
  Shared Function tt(ByVal inner As String, ByVal id As String) As String
    Return tt_ID(inner, id)
  End Function
  Shared Function tt(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return tt_ID_Class(inner, id, cssclass)
  End Function
  Shared Function u(ByVal inner As String) As String
    Return u_Generic(inner)
  End Function
  Shared Function u(ByVal inner As String, ByVal id As String) As String
    Return u_ID(inner, id)
  End Function
  Shared Function u(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return u_ID_Class(inner, id, cssclass)
  End Function
  Shared Function ul(ByVal inner As String) As String
    Return ul_Generic(inner)
  End Function
  Shared Function ul(ByVal inner As String, ByVal id As String) As String
    Return ul_ID(inner, id)
  End Function
  Shared Function ul(ByVal inner As String, ByVal id As String, ByVal cssclass As String) As String
    Return ul_ID_Class(inner, id, cssclass)
  End Function
End Class
