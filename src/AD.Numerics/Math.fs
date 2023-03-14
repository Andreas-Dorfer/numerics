[<AutoOpen>]
module AD.Numerics.Math

open System.Numerics

(* IAdditiveIdentity *)
let inline addId2<'a, 'b when 'a :> IAdditiveIdentity<'a, 'b>> : 'b = 'a.AdditiveIdentity 
let inline addId<'a when 'a :> IAdditiveIdentity<'a, 'a>> : 'a = addId2<'a, 'a>

(* IFloatingPoint *)
let inline round (a: 'a when 'a :> IFloatingPoint<'a>, digits, mode) : 'a = 'a.Round(a, digits, mode)

(* IDecrementOperators *)
let inline decr (a: 'a when 'a :> IDecrementOperators<'a>) : 'a = 'a.op_Decrement(a)
