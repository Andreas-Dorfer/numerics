﻿[<AutoOpen>]
module AD.Numerics.Operators

open System.Numerics

#nowarn "86"

(* IAdditionOperators *)
let inline (+) (a: 'a when 'a :> IAdditionOperators<'a, 'b, 'c>) (b: 'b) : 'c = 'a.(+)(a, b)

(* IComparisonOperators *)
let inline (>) (a: 'a when 'a :> IComparisonOperators<'a, 'b, 'c>) (b: 'b) : 'c = 'a.(>)(a, b)
let inline (>=) (a: 'a when 'a :> IComparisonOperators<'a, 'b, 'c>) (b: 'b) : 'c = 'a.(>=)(a, b)
let inline (<) (a: 'a when 'a :> IComparisonOperators<'a, 'b, 'c>) (b: 'b) : 'c = 'a.(<)(a, b)
let inline (<=) (a: 'a when 'a :> IComparisonOperators<'a, 'b, 'c>) (b: 'b) : 'c = 'a.(<=)(a, b)

(* IDivisionOperators *)
let inline (/) (a: 'a when 'a :> IDivisionOperators<'a, 'b, 'c>) (b: 'b) : 'c = 'a.(/)(a, b)

(* IEqualityOperators *)
let inline (=) (a: 'a when 'a :> IEqualityOperators<'a, 'b, 'c>) (b: 'b) : 'c = 'a.(=)(a, b)
let inline (<>) (a: 'a when 'a :> IEqualityOperators<'a, 'b, 'c>) (b: 'b) : 'c = 'a.(<>)(a, b)
