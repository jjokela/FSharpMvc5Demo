module TaxCalculator.Tests

// xUnit.net -> https://github.com/xunit/xunit
// get xUnit runners too to help running the tests
open Xunit
open System


// unit test
[<Fact>]
let salary_0_should_return_0() =
    Assert.Equal(0.0, TaxCalculator.Salary.amountOfTaxesPaid 0.0)

[<Fact>]
let salary_10000_should_return_0() =
    Assert.Equal(0.0, TaxCalculator.Salary.amountOfTaxesPaid 10000.0)

[<Fact>]
let salary_20000_should_return_2000() =
    Assert.Equal(2000.0, TaxCalculator.Salary.amountOfTaxesPaid 20000.0)

[<Fact>]
let salary_40000_should_return_6000() =
    Assert.Equal(6000.0, TaxCalculator.Salary.amountOfTaxesPaid 40000.0)

[<Fact>]
let salary_60000_should_return_13627() =
    Assert.Equal(13627.0, Math.Round(TaxCalculator.Salary.amountOfTaxesPaid 60000.0, 0))

[<Fact>]
let salary_120000_should_return_41627() = 
    Assert.Equal(41627.0, Math.Round(TaxCalculator.Salary.amountOfTaxesPaid 120000.0, 0))

[<Fact>]
let salary_170000_should_return_62627() = 
    Assert.Equal(62626.0, Math.Round(TaxCalculator.Salary.amountOfTaxesPaid 170000.0, 0))