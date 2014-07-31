namespace TaxCalculator.WebApp.Models

open System.ComponentModel
open System.ComponentModel.DataAnnotations

open TaxCalculator

type TaxCalculatorResult(request: TaxCalculatorRequest) =

    let taxesPaid = TaxCalculator.Salary.amountOfTaxesPaid request.GrossSalaryPerAnnum

    [<DisplayName("Gross salary per annum")>]
    member x.GrossSalaryPerAnnum = request.GrossSalaryPerAnnum

    [<DisplayName("Taxes paid per annum")>]
    member x.TaxesPaidPerAnnum = taxesPaid
