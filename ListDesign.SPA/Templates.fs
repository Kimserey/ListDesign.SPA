namespace ListDesign.SPA

open WebSharper
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI.Next
open WebSharper.UI.Next.Client

[<JavaScript; AutoOpen>]
module Templates =    
    type Index = Templating.Template<"index.html">
    type Card  = Templating.Template<"Templates/template-card.html">
    type Nav   = Templating.Template<"Templates/template-nav.html">
    type Table = Templating.Template<"Templates/template-table.html">
