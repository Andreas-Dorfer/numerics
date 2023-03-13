namespace AD.Numerics.Tests

open type Microsoft.VisualStudio.TestTools.UnitTesting.Assert

[<AutoOpen>]
module Operators =

    let (=!) actual expected = AreEqual(expected, actual)
