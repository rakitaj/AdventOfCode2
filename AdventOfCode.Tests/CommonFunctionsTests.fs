module CommonFunctionsTests

open Xunit
open CommonFunctions
open AdventOfCode.Solutions.Common
open FsUnit.Xunit

[<Theory>]
[<InlineData("abcdef", "609043", "000001DBBFA3A5C83A2D506429C7B00E")>]
[<InlineData("pqrstuv", "1048970", "000006136EF2FF3B291C85725F17325C")>]
let ``Test calculating an MD5 hash from a seed and suffix`` (seed: string, suffix: string, expected: string) =
    let md5Hash = calcMd5HashWithSeed seed suffix
    md5Hash |> should equal expected

[<Fact>]
let ``Test grid from a 1D array and row size chunks correcctly`` () =
    let arrayData = [|1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11; 12|]
    let grid = Grid(arrayData, 4)
    grid.Raw.Count |> should equal 3
    grid.Raw.[0].Count |> should equal 4

[<Fact>]
let ``Test Points with the same values should be equal`` () =
    Point(3, 8) |> should equal (Point(3, 8))

[<Fact>]
let ``Test Points with different values should not be equal`` () =
    Point(2, 8) = Point(3, 8) |> should be False