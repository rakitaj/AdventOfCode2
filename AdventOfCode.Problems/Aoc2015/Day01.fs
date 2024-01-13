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

let part1Solution : int = 
    let line = DataLoaders.readFile(2015, "day01.txt")
    calcFloor(line)

let firstBasementIndex (line: string) : int =
    let mutable minFloorNegativeIndex = line.Length
    let mutable floorNum = 0
    for i in 0..line.Length - 1 do
        floorNum <- floorNum + mapParenToValue line[i]
        if floorNum = -1 && i < minFloorNegativeIndex then
            minFloorNegativeIndex <- i
    minFloorNegativeIndex + 1

let part2Solution : int =
    DataLoaders.readFile(2015, "day01.txt")
    |> firstBasementIndex
    
