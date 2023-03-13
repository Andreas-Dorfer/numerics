namespace AD.Numerics.Tests.Checked

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
open AD.Numerics.Tests.TestOperators
open SystemMath
open AD.Numerics.Checked

[<TestClass>]
type MathTests () =

    [<Property>]
    member _.DecrInt a = decr a =! decrInt a

    [<Property>]
    member _.DecrFloat a = decr a =! decrFloat a

    [<Property>]
    member _.DecrDecimal a = decr a =! decrDecimal a
