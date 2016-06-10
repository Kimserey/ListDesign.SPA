namespace ListDesign.SPA

open WebSharper
open WebSharper.Resources

module Resources =
    
    module FontAwesome = 
        type Otf() =
           inherit BaseResource("FontAwesome.otf")
        type Eot() =
           inherit BaseResource("fontawesome-webfont.eot")
        type Svg() =
           inherit BaseResource("fontawesome-webfont.svg")
        type Ttf() =
           inherit BaseResource("fontawesome-webfont.ttf")
        type Woff() =
           inherit BaseResource("fontawesome-webfont.woff")
        type Woff2() =
           inherit BaseResource("fontawesome-webfont.woff2")
    
        [<assembly:System.Web.UI.WebResource("FontAwesome.otf", "");
          assembly:System.Web.UI.WebResource("fontawesome-webfont.eot", "");
          assembly:System.Web.UI.WebResource("fontawesome-webfont.svg", "");
          assembly:System.Web.UI.WebResource("fontawesome-webfont.ttf", "");
          assembly:System.Web.UI.WebResource("fontawesome-webfont.woff", "");
          assembly:System.Web.UI.WebResource("fontawesome-webfont.woff2", "");

          assembly:Require(typeof<Eot>);
          assembly:Require(typeof<Otf>);
          assembly:Require(typeof<Svg>);
          assembly:Require(typeof<Ttf>);
          assembly:Require(typeof<Woff>);
          assembly:Require(typeof<Woff2>)>]
        do()
        
    module SimpleUI =
        type Css() =
            inherit BaseResource("simple_ui.css")
        type Js() =
            inherit BaseResource("simple_ui.js")

        [<assembly:System.Web.UI.WebResource("simple_ui.css", "text/css");
          assembly:System.Web.UI.WebResource("simple_ui.js", "text/javascript");
          
          assembly:Require(typeof<Css>);
          assembly:Require(typeof<Js>)>]
        do()
