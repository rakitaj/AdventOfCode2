namespace Tests.Year2015

open Xunit
open Aoc2015.Day01
open Aoc2015.Day02
open FsUnit.Xunit

module Day01Tests = 

    [<Theory>]
    [<InlineData("(())", 0)>]
    [<InlineData("(()(()(", 3)>]
    let ``Test finding the floor num`` (line: string, expected: int) =
        let floorNum = calcFloor line
        floorNum |> should equal expected

    [<Theory>]
    [<InlineData(")", 1)>]
    [<InlineData("()())", 5)>]
    [<InlineData("())()", 3)>]
    let ``Test finding the first bastment index`` (line: string, expected: int) =
        let minbasementIdex = firstBasementIndex line
        minbasementIdex |> should equal expected

module Day02Tests = 

    [<Theory>]
    [<InlineData("2x3x4", 58)>]
    [<InlineData("1x1x10", 43)>]
    let ``Test calculating the surface area of the wrapping paper`` (line: string, expected: int) =
        let boxDimensions = parseLine line
        calculateWrappingPaper boxDimensions |> should equal expected

    [<Theory>]
    [<InlineData("2x3x4", 34)>]
    [<InlineData("1x1x10", 14)>]
    let ``Test calculating the of ribbon needed`` (line: string, expected: int) =
        let boxDimensions = parseLine line
        calculateRibbonLength boxDimensions |> should equal expected
