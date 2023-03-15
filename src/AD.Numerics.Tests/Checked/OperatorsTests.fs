namespace AD.Numerics.Tests.Checked

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
open System
open AD.Numerics.Tests.TestOperators
open SystemOperators
open AD.Numerics.Checked

[<TestClass>]
type OperatorsTests () =

    [<Property>]
    member _.AddInt (a, b) = a + b =! addInt (a, b)

    [<Property>]
    member _.AddFloat (a, b) = a + b =! addFloat (a, b)

    [<Property>]
    member _.AddDecimal (a, b) = a + b =! addDecimal (a, b)

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
