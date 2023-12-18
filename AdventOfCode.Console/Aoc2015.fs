module Aoc2015.Problems

open DataLoaders

let mapParenToValue (c: char): int =
    match c with
    | '(' -> 1
    | ')' -> -1
    | _ -> 0

let calcFloor (line: string) : int =
    line |> Seq.map mapParenToValue |> Seq.sum

let day01Solution () : int = 
    let line = DataLoaders.readFile(2015, "day01.txt")
    calcFloor(line)

let indexOfFirstNegative (line: string) : int =
    let parenValues = line |> Seq.map mapParenToValue
    let f = fun (n: int) (acc: int) int -> n + acc
    // List.scan(fun (runningTotal:int) list -> (list |> matchParen) + runningTotal)
    // |> Seq.find (fun x -> x = -1)
    // let mutable count = 0
    // let mutable negativeIndices = Array.zeroCreate line.Length
    // for i in 0..line.Length - 1 do
    //     match line[i] with
    //     | '(' -> count <- count + 1
    //     | ')' -> count <- count - 1
    //     | _ -> ()
    //     if count < 0 then
    //         negativeIndices[i] <- 1
    // negativeIndices |> Seq.find (fun x -> x = 1)
    -1
    

let day02Solution () : int =
    DataLoaders.readFile(2015, "day01.txt")
    |> indexOfFirstNegative