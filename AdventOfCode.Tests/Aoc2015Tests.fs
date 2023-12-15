namespace Tests.Year2015

open Xunit
open Aoc2015.Problems
open FsUnit.Xunit

module Day01 = 

    [<Fact>]
    let ``Test counting parenthesis`` () =
        let parenCounts = countParens("(())")
        parenCounts |> should equal (2, 2)

    [<Theory>]
    [<InlineData("(())", 0)>]
    [<InlineData("(()(()(", 3)>]
    let ``Test finding the floor num`` (line: string, expected: int) =
        let floorNum = calcFloor line
        floorNum |> should equal expected