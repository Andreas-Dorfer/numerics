namespace AD.Numerics.Tests

type Digits = private Digits of int

open Microsoft.VisualStudio.TestTools.UnitTesting
open FsCheck

[<TestClass>]
type Arbitraries () =

    static member DigitsArbitrary () =
        gen {
            let! digits = (0, 10) |> Gen.choose
            return Digits digits
        } |> Arb.fromGen

    [<AssemblyInitialize>]
    static member Initialize(_: TestContext) =
        Arb.register<Arbitraries>() |> ignore
