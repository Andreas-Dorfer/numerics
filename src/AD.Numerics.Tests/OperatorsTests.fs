namespace AD.Numerics.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
open SystemOperators
open AD.Numerics

[<TestClass>]
type OperatorsTests () =

    let assertAdd a b expected =
        let actual = a + b
        actual =! expected

    [<Property>]
    member _.AddInt (a, b) = addInt (a, b) |> assertAdd a b

    [<Property>]
    member _.AddFloat (a, b) = addFloat (a, b) |> assertAdd a b

    [<Property>]
    member _.AddDecimal (a, b) = addDecimal (a, b) |> assertAdd a b
