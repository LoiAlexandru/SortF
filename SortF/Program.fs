// Learn more about F# at http://fsharp.org

open System
let arr = [1; 5; 89; 2; 5; 1; 2]
let sort l = 
  let rec sortUtil acc rev l =
    match l, rev with
    | [], true -> acc |> List.rev
    | [], false -> acc |> List.rev |> sortUtil [] true
    | x::y::tl, _ when x > y -> sortUtil (y::acc) false (x::tl)
    | hd::tl, _ -> sortUtil (hd::acc) rev tl
  sortUtil [] true l

[<EntryPoint>]

let main argv = 
    printfn "%A" (sort arr)
    0