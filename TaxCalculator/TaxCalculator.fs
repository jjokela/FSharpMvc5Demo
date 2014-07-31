module TaxCalculator.Salary

let amountOfTaxesPaid grossSalaryPerAnnum = 
    if grossSalaryPerAnnum < 0.0 then failwith "Annual salary has to be greater than zero."
    
    let grossSalaryAfterDeductions = 
        match grossSalaryPerAnnum with
        | grossSalaryPerAnnum when grossSalaryPerAnnum > 100000.0 -> grossSalaryPerAnnum
        | _ -> grossSalaryPerAnnum - 10000.0

    let basicRate = 
        match grossSalaryAfterDeductions with
        | grossSalaryAfterDeductions when grossSalaryAfterDeductions <= 0.0 -> 0.0
        | grossSalaryAfterDeductions when grossSalaryAfterDeductions < 31865.0 -> grossSalaryAfterDeductions * 0.2
        | _ -> 31865.0 * 0.2

    let higherRate = 
        match grossSalaryAfterDeductions with
        | grossSalaryAfterDeductions when grossSalaryAfterDeductions <= 31866.0 -> 0.0
        | grossSalaryAfterDeductions when grossSalaryAfterDeductions > 150000.0 -> (150000.0 - 31866.0) * 0.4
        | _ -> (grossSalaryAfterDeductions - 31866.0) * 0.4

    let additionalRate = 
        match grossSalaryAfterDeductions with
        | grossSalaryAfterDeductions when grossSalaryAfterDeductions > 150000.0 -> (grossSalaryAfterDeductions - 150001.0) * 0.45
        | _ -> 0.0

    let totalAmountOfTaxesPaid = basicRate + higherRate + additionalRate
    totalAmountOfTaxesPaid

