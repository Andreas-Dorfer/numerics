namespace AD.Numerics.Tests.Checked

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
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
    member _.DivInt (a, b) = a / b =! divInt (a, b)

    [<Property>]
    member _.DivFloat (a, b) = a / b =! divFloat (a, b)

    [<Property>]
    member _.DivDecimal (a, b) = a / b =! divDecimal (a, b)
