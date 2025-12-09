module Aoc2025.Day01
open DataLoaders

let parse (line: string) : Result<int, string> =
    let amount = int line.[1..]
    match line.[0] with
    | 'L' -> Ok (amount * -1)
    | 'R' -> Ok amount
    | c -> Error $"Unknown direction '{c}'"


let rec calc (pos: int) (zeroCount: int) (parsedAmounts: int list)  : int =
    match parsedAmounts with
    | [] -> zeroCount
    | head :: tail -> 
        let pos = (pos + head) % 100
        let zeroCount = zeroCount + if pos = 0 then 1 else 0
        calc pos zeroCount tail

let part1Solution (input: string) : Answer =
    input |> splitLines
    |> Seq.map parse
    |> Seq.choose (function
        | Ok v -> Some v
        | Error e -> 
            printfn "Failed: %s" e
            None)
    |> Seq.toList
    |> calc 50 0
    |> Answer.Int32

let part2Solution input = "todo" |> Answer.Text

let challenge: AocChallenge = {
    Year = 2025
    Day = 1
    Part1 = part1Solution
    Part2 = part2Solution
}