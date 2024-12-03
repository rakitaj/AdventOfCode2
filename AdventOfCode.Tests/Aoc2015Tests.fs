namespace Tests.Year2015

open Aoc2015.Day01
open Aoc2015.Day02
open Aoc2015.Day03
open FsUnit.MsTest
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type Day01Tests () =

    [<TestMethod>]
    [<DataRow("(())", 0)>]
    [<DataRow("(()(()(", 3)>]
    member this.``Test finding the floor num``(line: string, expected: int) =
        let floorNum = calcFloor line
        floorNum |> should equal expected

    [<TestMethod>]
    [<DataRow(")", 1)>]
    [<DataRow("()())", 5)>]
    [<DataRow("())()", 3)>]
    member this.``Test finding the first bastment index`` (line: string, expected: int) =
        let minbasementIdex = floorNumRunningTotal line |> firstNegativeFloor
        minbasementIdex |> should equal expected

[<TestClass>]
type Day02Tests () = 

    [<TestMethod>]
    [<DataRow("2x3x4", 58)>]
    [<DataRow("1x1x10", 43)>]
    member this.``Test calculating the surface area of the wrapping paper`` (line: string, expected: int) =
        let boxDimensions = parseLine line
        calculateWrappingPaper boxDimensions |> should equal expected

    [<TestMethod>]
    [<DataRow("2x3x4", 34)>]
    [<DataRow("1x1x10", 14)>]
    member this.``Test calculating the of ribbon needed`` (line: string, expected: int) =
        let boxDimensions = parseLine line
        calculateRibbonLength boxDimensions |> should equal expected

[<TestClass>]
type Day03Tests () =

    [<TestMethod>]
    [<DataRow(">", 2)>]
    [<DataRow("^>v<", 4)>]
    [<DataRow("^v^v^v^v^v", 2)>]
    member this.``Test delivering presents path`` (line: string, expected: int) =
        housesVisitedCount line |> should equal expected

    // [<TestMethod>]
    // [<DataRow("^v", 3)>]
    // [<DataRow("^>v<", 3)>]
    // [<DataRow("^v^v^v^v^v", 11)>]
    // let ``Test robo Santa delivering presents path`` (line: string, expected: int) =
    //     let housesVisited = housesVisitedRoboSanta (0, 0) line
    //     housesVisited.Count |> should equal expected