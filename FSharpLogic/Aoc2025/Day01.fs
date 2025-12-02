module Aoc2025.Day01

let data = DataLoaders.readFileLinesStr 2025 01

let parse (line: string) : Result<int, string> =
    let amount = int line.[1..]
    match line.[0] with
    | 'L' -> Ok (amount * -1)
    | 'R' -> Ok amount
    | c -> Error $"Unknown direction '{c}'"


// let calculatePart1 (lines: string seq) : int = 
//     let parsedAmounts = lines |> Seq.choose parse
//     let _, zeroCount = parsedAmounts |> Seq.fold ()
    // let pos = 50
    // let zeroCount = 0
    // for amount in amounts {
    //     pos += amount
    //     pos = pos % 100
    //     if pos == 0 {
    //         zeroCount += 1
    //     }
    // }
    // zeroCount
let rec calc (pos: int) (zeroCount: int) (parsedAmounts: int list)  : int =
    match parsedAmounts with
    | [] -> zeroCount
    | head :: tail -> 
        let pos = (pos + head) % 100
        let zeroCount = zeroCount + if pos = 0 then 1 else 0
        calc pos zeroCount tail

let part1Solution : int =
    data
    |> Seq.map parse
    |> Seq.choose (function
        | Ok v -> Some v
        | Error e -> 
            printfn "Failed: %s" e
            None)
    |> Seq.toList
    |> calc 50 0
