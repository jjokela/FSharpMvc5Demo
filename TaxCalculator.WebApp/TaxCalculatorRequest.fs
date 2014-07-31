namespace TaxCalculator.WebApp.Models

open System.ComponentModel
open System.ComponentModel.DataAnnotations

open TaxCalculator

type TaxCalculatorRequest() =
    let mutable grossSalaryPerAnnum = 0.0

    [<Required>]
    [<DisplayName("Gross salary per annum")>]
    member x.GrossSalaryPerAnnum 
        with get() = grossSalaryPerAnnum
        and set v = grossSalaryPerAnnum <- v


