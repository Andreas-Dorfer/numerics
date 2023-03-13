module AD.Numerics.Tests.CheckedSystemOperators

open Operators.Checked

let inline addInt (a, b) = a + b

let inline addFloat (a: float, b) = a + b

let inline addDecimal (a: decimal, b) = a + b
