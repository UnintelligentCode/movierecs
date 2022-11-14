module App

open Browser
open Browser.Types
open Fable.Core

// getting the body element to add everything else
let body = document.getElementById "body" :?> HTMLBodyElement
// creation of new elements to be added to the body
let mainDiv = document.createElement "div" :?> HTMLDivElement
//setting attribute for main div
let mainHeader = document.createElement "h1"

// elements to the body
body.appendChild mainDiv |> ignore
mainDiv.appendChild mainHeader |> ignore

// creating header text
mainHeader.textContent <- "TEST"