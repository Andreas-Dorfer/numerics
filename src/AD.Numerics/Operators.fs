[<AutoOpen>]
module AD.Numerics.Operators

open System.Numerics

(* IAdditionOperators *)
let inline (+) (a: 'a when 'a :> IAdditionOperators<'a, 'b, 'c>) (b: 'b) : 'c = 'a.(+)(a, b)
