[<AutoOpen>]
module AD.Numerics.Tests.TestOperators

open type Microsoft.VisualStudio.TestTools.UnitTesting.Assert

let (=!) actual expected = AreEqual(expected, actual)
