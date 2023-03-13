namespace AD.Numerics.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
open SystemOperators
open AD.Numerics

[<TestClass>]
type OperatorsTests () =

    [<Property>]
    member _.AddInt (a, b) = a + b =! addInt (a, b)

    [<Property>]
    member _.AddFloat (a, b) = a + b =! addFloat (a, b)

    [<Property>]
    member _.AddDecimal (a, b) = a + b =! addDecimal (a, b)

    [<Property>]
    member _.GtInt (a, b) = a > b =! gtInt (a, b)

    [<Property>]
    member _.GtFloat (a, b) = a > b =! gtFloat (a, b)

    [<Property>]
    member _.GtDecimal (a, b) = a > b =! gtDecimal (a, b)

    [<Property>]
    member _.GteInt (a, b) = a >= b =! gteInt (a, b)

    [<Property>]
    member _.GteFloat (a, b) = a >= b =! gteFloat (a, b)

    [<Property>]
    member _.GteDecimal (a, b) = a >= b =! gteDecimal (a, b)

    [<Property>]
    member _.LtInt (a, b) = a < b =! ltInt (a, b)

    [<Property>]
    member _.LtFloat (a, b) = a < b =! ltFloat (a, b)

    [<Property>]
    member _.LtDecimal (a, b) = a < b =! ltDecimal (a, b)

    [<Property>]
    member _.LteInt (a, b) = a <= b =! lteInt (a, b)

    [<Property>]
    member _.LteFloat (a, b) = a <= b =! lteFloat (a, b)

    [<Property>]
    member _.LteDecimal (a, b) = a <= b =! lteDecimal (a, b)
