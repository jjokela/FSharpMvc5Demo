namespace FSharpMvc5Demo.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Web
open System.Web.Mvc
open System.Web.Mvc.Ajax

open TaxCalculator.WebApp.Models

type TaxCalculatorController() =
    inherit Controller()

    [<HttpGet>]
    member x.Index() = 
        let taxCalculatorModel = 
            TaxCalculatorRequest(GrossSalaryPerAnnum = 0.0)
        x.View(taxCalculatorModel) 

    [<HttpPost>]
    member x.Index(calcRequest: TaxCalculatorRequest) = 
        if not x.ModelState.IsValid then (x.View(calcRequest))
        else
            x.View("TaxCalculatorResult", TaxCalculatorResult(calcRequest))
