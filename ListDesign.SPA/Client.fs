namespace ListDesign.SPA

open WebSharper
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI.Next
open WebSharper.UI.Next.Client
open WebSharper.UI.Next.Html

[<JavaScript>]
module Client =
    
    let main() =
        Templates.Index.Doc("Expenses", [ text "Hello world" ])
        |> Doc.RunById "main"
