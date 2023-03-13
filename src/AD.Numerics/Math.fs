[<AutoOpen>]
module AD.Numerics.Math

open System.Numerics

(* IFloatingPoint *)
let inline round mode digits (a: 'a when 'a :> IFloatingPoint<'a>) : 'a = 'a.Round(a, digits, mode)
