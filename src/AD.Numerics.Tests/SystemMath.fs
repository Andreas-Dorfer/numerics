module AD.Numerics.Tests.SystemMath

open type System.Math

let roundFloat (a: float, digits, mode) = Round(a, digits, mode)

let roundDecimal (a: decimal, digits, mode) = Round(a, digits, mode)

let decrInt a = a - 1

let decrFloat a = a - 1.0

let decrDecimal a = a - 1m
