﻿namespace AD.Numerics.Tests

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
