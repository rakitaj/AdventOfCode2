﻿module CommonFunctionsTests

open CommonFunctions
open EverybodyCodes.Common
open FsUnit.MsTest
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestMethod>]
[<DataRow("abcdef", "609043", "000001DBBFA3A5C83A2D506429C7B00E")>]
[<DataRow("pqrstuv", "1048970", "000006136EF2FF3B291C85725F17325C")>]
let ``Test calculating an MD5 hash from a seed and suffix`` (seed: string, suffix: string, expected: string) =
    let md5Hash = calcMd5HashWithSeed seed suffix
    md5Hash |> should equal expected

[<TestMethod>]
let ``Test grid from a 1D array and row size chunks correcctly`` () =
    let arrayData = [|1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11; 12|]
    let grid = Grid(arrayData, 4)
    grid.Raw.Count |> should equal 3
    grid.Raw.[0].Count |> should equal 4

[<TestMethod>]
let ``Test Points with the same values should be equal`` () =
    Point(3, 8) |> should equal (Point(3, 8))

[<TestMethod>]
let ``Test Points with different values should not be equal`` () =
    Point(2, 8) = Point(3, 8) |> should be False

[<TestMethod>]
[<DataRow(0, 0, '.')>]
[<DataRow(1, 1, 'F')>]
[<DataRow(1, 2, '|')>]
[<DataRow(3, 1, '7')>]
let ``Test Grid get point`` (x: int) (y: int) (expected: char) =
    let sampleGridData = """.....
.F-7.
.|.|.
.L-J.
....."""
    let grid = sampleGridData.Split() |> Grid<char>.FromStringLists
    grid.Get(x, y) |> should equal expected

[<TestMethod>]
[<DataRow(0, 0, true)>]
[<DataRow(1, 1, true)>]
[<DataRow(1, 2, true)>]
[<DataRow(-1, 2, false)>]
[<DataRow(5, 1, false)>]
let ``Test Grid in bounds`` (x: int) (y: int) (expected: bool) =
    let sampleGridData = """.....
.F-7.
.|.|.
.L-J.
....."""
    let grid = sampleGridData.Split() |> Grid<char>.FromStringLists
    grid.InBounds(x, y) |> should equal expected

[<TestMethod>]
let ``Test Grid adjacent points`` () =
    let sampleGridData = """.....
.F-7.
.|.|.
.L-J.
....."""
    let grid = sampleGridData.Split() |> Grid<char>.FromStringLists
    let p = Point(0, 2)
    grid.Adjacent(p).Count |> should equal 5