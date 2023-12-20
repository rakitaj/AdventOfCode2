module CommonFunctionsTests

open Xunit
open CommonFunctions
open FsUnit.Xunit

[<Theory>]
[<InlineData("abcdef", "609043", "000001DBBFA3A5C83A2D506429C7B00E")>]
[<InlineData("pqrstuv", "1048970", "000006136EF2FF3B291C85725F17325C")>]
let ``Test calculating an MD5 hash from a seed and suffix`` (seed: string, suffix: string, expected: string) =
    let md5Hash = calcMd5HashWithSeed seed suffix
    md5Hash |> should equal expected

[<Fact>]
let ``Test integer sequence with max number defined`` () =
    let integers = integerSeq (Some 6)
    integers |> Seq.take 1 |> should equalSeq (seq { 0 })
    integers |> Seq.take 2 |> should equalSeq (seq { 1; 2 })
    integers |> Seq.take 2 |> should equalSeq (seq { 7 })