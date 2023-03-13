[<AutoOpen>]
module AD.Numerics.Checked.Math

open System.Numerics

(* IDecrementOperators *)
let inline decr (a: 'a when 'a :> IDecrementOperators<'a>) : 'a = 'a.op_CheckedDecrement(a)
