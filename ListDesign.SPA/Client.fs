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
        Nav.Doc(
            "Expenses", 
            "List design", 
            [ Nav.Category.Doc("Expenses", [ a [ text "1" ]; a [ text "2" ] ])
              Nav.Category.Doc("Dates", [ a [ text "1" ]; a [ text "2" ] ]) ])
        |> Doc.RunById "nav"

    let content =
        Templates.Card.Doc(
            "firstContent", 
            [ Card.Header.Doc("Supermarket", "20.00") ],
            [ Table.Doc([ Table.Header.Doc("", "Date")
                          Table.Header.Doc("amount", "Amount") ],
                        [ ]) ])
        |> Doc.RunById "content"
