namespace AD.Numerics.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
open TestOperators
open SystemMath
open AD.Numerics

[<TestClass>]
type MathTests () =

    [<TestMethod>]
    member _.AddIdInt () = addId =! 0

    [<TestMethod>]
    member _.AddIdFloat () = addId =! 0.0

    [<TestMethod>]
    member _.AddIdDecimal () = addId =! 0m

    [<Property>]
    member _.RoundFloat (mode, (Digits digits), a) = round mode digits a =! roundFloat (a, digits, mode)
    
    [<Property>]
    member _.RoundDecimal (mode, (Digits digits), a) = round mode digits a =! roundDecimal (a, digits, mode)

    [<Property>]
    member _.DecrInt a = decr a =! decrInt a

    [<Property>]
    member _.DecrFloat a = decr a =! decrFloat a

    [<Property>]
    member _.DecrDecimal a = decr a =! decrDecimal a
