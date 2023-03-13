namespace AD.Numerics.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
open type System.Math
open AD.Numerics

[<TestClass>]
type MathTests () =

    let assertRound mode digits a expected =
        let actual = a |> round mode digits
        actual =! expected

    [<Property>]
    member _.RoundFloat (mode, (Digits digits), a: float) = Round(a, digits, mode) |> assertRound mode digits a
    
    [<Property>]
    member _.RoundDecimal (mode, (Digits digits), a: decimal) = Round(a, digits, mode) |> assertRound mode digits a
