module DataLoaders

open System.IO
open System

let assemblyDirectory = AppDomain.CurrentDomain.BaseDirectory

let readFile (year: int) (filename: string) : string = 
    Path.Combine(assemblyDirectory, "./Data", $"{year}", filename) 
    |> File.ReadAllText

let readFileLines (year: int, filename: string) : string array =
    Path.Combine(assemblyDirectory, "./Data", $"{year}", filename) 
    |> File.ReadAllLines

let readFileLinesStr (year: int)  (day: int) : string array =
    let formattedDay = sprintf "day%02i.txt" day
    readFileLines(year, formattedDay)

let readFileLinesInt (year: int) (day: int) : int array =
    readFileLinesStr year day |> Array.map int

let readEveryoneCodes (filename: string) : string =
    Path.Combine(assemblyDirectory, "./Data/EveryoneCodes", filename) 
    |> File.ReadAllText
