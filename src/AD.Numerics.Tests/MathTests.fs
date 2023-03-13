namespace AD.Numerics.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
open SystemOperators
open type System.Math
open AD.Numerics

[<TestClass>]
type MathTests () =

    [<Property>]
    member _.AddIdInt a = addInt (a, addId) =! a

    [<Property>]
    member _.RoundFloat (mode, (Digits digits), a: float) = round mode digits a =! Round(a, digits, mode)
    
    [<Property>]
    member _.RoundDecimal (mode, (Digits digits), a: decimal) = round mode digits a =! Round(a, digits, mode)
