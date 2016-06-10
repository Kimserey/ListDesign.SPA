namespace ListDesign.SPA

open WebSharper
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI.Next
open WebSharper.UI.Next.Client
open WebSharper.UI.Next.Html

[<JavaScript>]
module Client =
    
    let nav = 
        Templates.Nav.Doc(
            "Expenses", 
            "List design", 
            [ Templates.Nav.ListItem.Doc("Expenses", [ a [ text "1" ]; a [ text "2" ] ])
              Templates.Nav.ListItem.Doc("Dates", [ a [ text "1" ]; a [ text "2" ] ]) ])
        |> Doc.RunById "nav"

    let content =
        Templates.Card.Doc()
        |> Doc.RunById "content"
