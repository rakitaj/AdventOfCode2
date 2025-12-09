module DataLoaders

open System.IO
open System

let assemblyDirectory = AppDomain.CurrentDomain.BaseDirectory

let readFile (year: int) (filename: string) : string = 
    Path.Combine(assemblyDirectory, "./Data", $"{year}", filename) 
    |> File.ReadAllText

let readFileString (year: int)  (day: int) : string =
    let formattedDay = sprintf "day%02i.txt" day
    readFile year formattedDay

let splitLines (raw: string) : string array =
    raw.Split Environment.NewLine

let readEveryoneCodes (filename: string) : string =
    Path.Combine(assemblyDirectory, "./Data/EveryoneCodes", filename) 
    |> File.ReadAllText

type Answer =
    | Int64 of int64
    | Int32 of int
    | Number of float
    | Text of string

    override this.ToString() =
        match this with
        | Int32 i -> string i
        | Int64 i -> string i
        | Text s    -> s
        | Number f  -> sprintf "%g" f

type AocChallenge =
    { Year  : int
      Day   : int
      Part1 : string -> Answer
      Part2 : string -> Answer }
