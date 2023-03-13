[<AutoOpen>]
module AD.Numerics.Checked.Operators

open System.Numerics

(* IAdditionOperators *)
let inline (+) (a: 'a when 'a :> IAdditionOperators<'a, 'b, 'c>) (b: 'b) : 'c = 'a.op_CheckedAddition(a, b)
