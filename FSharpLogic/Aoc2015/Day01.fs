module Aoc2015.Day01
open DataLoaders

let mapParenToValue (c: char): int =
    match c with
    | '(' -> 1
    | ')' -> -1
    | _ -> 0 

let calcFloor (line: string) : int =
    let f = fun (acc: int) (elem: char) ->  acc + mapParenToValue elem
    Seq.fold f 0 line
    
let floorNumRunningTotal (line: string) : int seq =
    let f = fun (acc: int) (elem: char) ->  acc + mapParenToValue elem
    Seq.scan f 0 line

let firstNegativeFloor (running_total: int seq) : int =
    running_total |> Seq.findIndex ((=) -1)

let part1 (input:string) =
    input |> calcFloor |> Answer.Int32

let part2 (input:string) =
    input |> floorNumRunningTotal |> firstNegativeFloor |> Answer.Int32
    

let challenge: AocChallenge = { 
    Year  = 2015
    Day   = 1
    Part1 = part1
    Part2 = part2 
}