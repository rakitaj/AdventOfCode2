module Aoc2015.Day02

open DataLoaders

type Box = {L: int; W: int; H: int}

let parseLine (line: string) : Box =
    let parts = line.Split('x')
    let dimensions = parts |> Seq.map int |> Seq.toList
    { L = dimensions[0]; W = dimensions[1]; H = dimensions[2] }

let calculateWrappingPaper (box: Box): int =
    let surfaceAreas = [box.L * box.W; box.W * box.H; box.H * box.L]
    (2 * surfaceAreas[0]) + (2 * surfaceAreas[1]) + (2 * surfaceAreas[2]) + (surfaceAreas |> Seq.min)

let calculateRibbonLength (box: Box): int =
    let minTwoSides = [box.H; box.L; box.W] |> Seq.sort |> Seq.toArray
    minTwoSides[0] + minTwoSides[0] + minTwoSides[1] + minTwoSides[1] + (box.H * box.L * box.W)

let part1Solution = 
    let lines = DataLoaders.readFileLinesByDay(2015, 2)
    lines |> Seq.map parseLine |> Seq.map calculateWrappingPaper |> Seq.sum

let part2Solution = 
    let lines = DataLoaders.readFileLinesByDay(2015, 2)
    lines |> Seq.map parseLine |> Seq.map calculateRibbonLength |> Seq.sum