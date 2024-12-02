module Aoc2015.Day01

let mapParenToValue (c: char): int =
    match c with
    | '(' -> 1
    | ')' -> -1
    | _ -> 0 

let calcFloor (line: string) : int =
    let f = fun (acc: int) (elem: char) ->  acc + mapParenToValue elem
    Seq.fold f 0 line

let part1Solution : int = 
    let line = DataLoaders.readFile(2015, "day01.txt")
    calcFloor(line)
    
let floorNumRunningTotal (line: string) : int seq =
    let f = fun (acc: int) (elem: char) ->  acc + mapParenToValue elem
    Seq.scan f 0 line

let firstNegativeFloor (running_total: int seq) : int =
    running_total |> Seq.findIndex ((=) -1)

let part2Solution : int =
    DataLoaders.readFile(2015, "day01.txt")
    |> floorNumRunningTotal
    |> firstNegativeFloor