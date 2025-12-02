module Aoc2015.Day03

type Coordinates = {X: int; Y: int}

let f = fun (acc: Coordinates) (c: char) -> 
        match c with
        | '^' -> { X=acc.X; Y=acc.Y + 1 }
        | '<' -> { X=acc.X - 1; Y=acc.Y }
        | '>' -> { X=acc.X + 1; Y=acc.Y }
        | 'v' -> { X=acc.X; Y=acc.Y - 1 }
        | _ -> acc

let housesVisitedCount (line: string) : int = 
    Seq.scan f {X=0;Y=0} line |> Seq.distinct |> Seq.length

let housesVisitedRoboSanta (line: string) : int = 
    5

let part1Solution = 
    let line = DataLoaders.readFile 2015  "day03.txt"
    line |> housesVisitedCount

let part2Solution = 
    let line = DataLoaders.readFile 2015 "day03.txt"
    line |> housesVisitedRoboSanta