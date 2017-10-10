// Learn more about F# at http://fsharp.org
open System

let array1 = [| 1; 2; 3; 4; 5; 6 |]
    for i in 0 .. array1.Length - 1 do
    printf "%d " array1.[i]
    printfn" "
    
    let array2 = [|
      1
      2
      3
      4
      5
   |]
for i in 0 .. array2.Length - 1 do
   printf "%d " array2.[i]
printfn" "

let array3 = [| for i in 1 .. 10 -> i * i |]
for i in 0 .. array3.Length - 1 do
   printf "%d " array3.[i]
printfn" "

Console.ReadLine()
