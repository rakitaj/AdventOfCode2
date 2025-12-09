open DataLoaders

let printChallenge (challenge: AocChallenge) =
    let input = DataLoaders.readFileString challenge.Year challenge.Day
    let p1 = challenge.Part1 input
    let p2 = challenge.Part2 input

    printfn "AOC %i Day %i" challenge.Year challenge.Day
    printfn "  Part 1: %O" p1
    printfn "  Part 2: %O" p2

printfn $"Advent Of Code 2015"
Aoc2015.Day01.challenge |> printChallenge
Aoc2015.Day02.challenge |> printChallenge
printfn $"Day 03-1 {Aoc2015.Day03.part1Solution}"
printfn $"Day 03-2 {Aoc2015.Day03.part2Solution}"

printfn $"Advent Of Code 2025"
// printfn $"Day 01-1 {Aoc2025.Day01.part1Solution}"
Aoc2025.Day01.challenge |> printChallenge