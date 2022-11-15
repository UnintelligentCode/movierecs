module App

open Browser
open Browser.Types
open Fable.Core

// getting the body element to add everything else
let body = document.getElementById "body" :?> HTMLBodyElement
let bodySize = 512/32
// creation of new elements to be added to the body
let mainDiv = document.createElement "div" :?> HTMLDivElement
//setting attributes & styles for main div
mainDiv.setAttribute("id", "movieCard")
mainDiv.style.setProperty("display", "grid")
mainDiv.style.setProperty("height", "256px")
mainDiv.style.setProperty("width", "256px")
mainDiv.style.setProperty("grid-template-columns", "auto")
mainDiv.style.setProperty("grid-template-rows", "auto")
mainDiv.style.setProperty("grid-template-areas", "\"h1 h1 h1 h1\" \"mc mc mc mc\" \"mc mc mc mc\" \"mc mc mc mc\" \"b1 b1 b2 b2\"")

let mainIMG = document.createElement "img" :?> HTMLImageElement
mainIMG.setAttribute("id", "mainIMG")
mainIMG.src <- "twk.jpg"
mainIMG.alt <- "The Woman King"
mainIMG.style.setProperty("grid-area", "mc")
mainIMG.style.setProperty("width", "256px")

let goodBtn = document.createElement "button" :?> HTMLButtonElement
goodBtn.setAttribute("id", "goodBtn")
goodBtn.textContent <- "Like"
goodBtn.style.backgroundColor <- "green"
goodBtn.style.setProperty("grid-row", "b2")
goodBtn.style.width <- "128px"

let badBtn = document.createElement "button" :?> HTMLButtonElement
badBtn.setAttribute("id", "badBtn")
badBtn.textContent <- "Dislike"
badBtn.style.backgroundColor <- "red"
badBtn.style.setProperty("grid-area", "b1")
badBtn.style.width <- "128px"

// creation of card header
let mainHeader = document.createElement "p"
//setting attributes & props for styles
mainHeader.setAttribute("id", "mainHeader")
mainHeader.textContent <- mainIMG.alt
mainHeader.style.backgroundColor <- ""
mainHeader.style.color <- "red"
mainHeader.style.setProperty("grid-area", "h1")
mainHeader.style.width <- "256px"
mainHeader.style.textAlign <- "center"

// elements to the body
body.appendChild mainDiv |> ignore
mainDiv.appendChild mainHeader |> ignore
mainDiv.appendChild mainIMG |> ignore
mainDiv.appendChild badBtn |> ignore
mainDiv.appendChild goodBtn |> ignore

let disableBtns() =
  badBtn.disabled <- true
  goodBtn.disabled <- true

badBtn.addEventListener("click", fun e -> disableBtns())
goodBtn.addEventListener("click", fun e -> disableBtns())