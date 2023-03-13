namespace AD.Numerics.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
open System
open AD.Numerics

[<TestClass>]
type MathTests () =

    let assertRound mode digits a expected =
        let actual = a |> round mode digits
        actual =! expected

    [<Property>]
    member _.RoundDecimal (mode, (Digits digits), a: decimal) = Math.Round(a, digits, mode) |> assertRound mode digits a

    [<Property>]
    member _.RoundFloat (mode, (Digits digits), a: float) = Math.Round(a, digits, mode) |> assertRound mode digits a
