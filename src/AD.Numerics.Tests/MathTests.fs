namespace AD.Numerics.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open AD.FsCheck.MSTest
open SystemMath
open SystemOperators
open AD.Numerics

[<TestClass>]
type MathTests () =

    [<Property>]
    member _.AddIdInt a = addInt (a, addId) =! a

    [<Property>]
    member _.AddIdFloat a = addFloat (a, addId) =! a

    [<Property>]
    member _.AddIdDecimal a = addDecimal (a, addId) =! a

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
