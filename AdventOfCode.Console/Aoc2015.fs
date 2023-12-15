module Aoc2015.Problems

open DataLoaders

let countParens (line: string) : int * int = 
    let mutable openParenCount = 0
    let mutable closeParenCount = 0
    for c in line do
        match c with
        | '(' -> openParenCount <- openParenCount + 1
        | ')' -> closeParenCount <- closeParenCount + 1
        | _ -> ()
    (openParenCount, closeParenCount)

let calcFloor (line: string) : int =
    let openParenCount, closeParenCount = countParens line
    openParenCount - closeParenCount

let day01Solution () : int = 
    let line = DataLoaders.readFile(2015, "day01.txt")
    calcFloor(line)

let indexOfFirstNegative (line: string) : int =
    let mutable count = 0
    let mutable negativeIndices = Array.zeroCreate line.Length
    for i in 0..line.Length - 1 do
        match line[i] with
        | '(' -> count <- count + 1
        | ')' -> count <- count - 1
        | _ -> ()
        if count < 0 then
            negativeIndices[i] <- 1
    negativeIndices |> Seq.find (fun x -> x = 1)
    

let day02Solution () : int =
    DataLoaders.readFile(2015, "day01.txt")
    |> indexOfFirstNegative