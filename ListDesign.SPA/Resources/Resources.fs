﻿namespace ListDesign.SPA

open WebSharper
open WebSharper.Resources

module Resources =
    
    module FontAwesome = 
        [<assembly:System.Web.UI.WebResource("FontAwesome.otf", "");
          assembly:System.Web.UI.WebResource("fontawesome-webfont.eot", "");
          assembly:System.Web.UI.WebResource("fontawesome-webfont.svg", "");
          assembly:System.Web.UI.WebResource("fontawesome-webfont.ttf", "");
          assembly:System.Web.UI.WebResource("fontawesome-webfont.woff", "");
          assembly:System.Web.UI.WebResource("fontawesome-webfont.woff2", "")>]
        do()
        
    module SimpleUI =
        type Css() =
            inherit BaseResource("simple_ui.css")
        type Js() =
            inherit BaseResource("simple_ui.js")

        [<assembly:Require(typeof<Css>);
          assembly:Require(typeof<Js>)>]
        do()
