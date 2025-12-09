module Aoc2015.Day03
open DataLoaders

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

let part1Solution data =     
    data |> housesVisitedCount |> Int32

let part2Solution data = 
    data |> housesVisitedRoboSanta |> Int32

let challenge = {
    Year = 2015
    Day = 3
    Part1 = part1Solution
    Part2 = part2Solution
}