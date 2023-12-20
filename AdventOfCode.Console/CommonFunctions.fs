module CommonFunctions

open System.Security.Cryptography

let calcMd5HashWithSeed (seed: string) (suffix: string): string =
    use md5 = MD5.Create()
    (seed + suffix) |> System.Text.Encoding.ASCII.GetBytes
    |> md5.ComputeHash
    |> System.Convert.ToHexString

let calcMd5Hash (input: string): string =
    use md5 = MD5.Create()
    input |> System.Text.Encoding.ASCII.GetBytes
    |> md5.ComputeHash
    |> System.Convert.ToHexString

let integerSeq (maxNum: int option) = seq { 
       let mutable current = 0
       match maxNum with
        | Some(x) ->
            if current < x then
                yield current
                current <- current + 1
        | None -> 
            yield current
            current <- current + 1
     }