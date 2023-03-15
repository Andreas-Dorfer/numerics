namespace AD.Numerics.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
open System
open TestOperators
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

    [<Property>]
    member _.DivInt (a, b) =
        let div () = a /b =! divInt (a, b)
        if b = 0 then
            Assert.ThrowsException<DivideByZeroException> div |> ignore
        else
            div ()

    [<Property>]
    member _.DivFloat (a, b) = a / b =! divFloat (a, b)

    [<Property>]
    member _.DivDecimal (a, b) =
        let div () = a /b =! divDecimal (a, b)
        if b = 0m then
            Assert.ThrowsException<DivideByZeroException> div |> ignore
        else
            div ()

    [<Property>]
    member _.EqInt (a, b) = a = b =! eqInt (a, b)

    [<Property>]
    member _.EqFloat (a, b) = a = b =! eqFloat (a, b)

    [<Property>]
    member _.EqDecimal (a, b) = a = b =! eqDecimal (a, b)

    [<Property>]
    member _.NotEqInt (a, b) = a <> b =! notEqInt (a, b)

    [<Property>]
    member _.NotEqFloat (a, b) = a <> b =! notEqFloat (a, b)

    [<Property>]
    member _.NotEqDecimal (a, b) = a <> b =! notEqDecimal (a, b)
