// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

PrintMenu();

int value;
string? userValue = "";
int.TryParse(userValue, out value);
decimal total = 0.00m;
bool exit = false;

while(!exit){
    Console.WriteLine("Enter a value from the menu.\n");
    userValue = Console.ReadLine();
    int.TryParse(userValue, out value);

    switch(value){
        case 1:
            decimal sum;
            decimal interestPrc;
            int nrOfYears;

            Console.WriteLine("Enter the sum you want to invest into the deposit.");
            string? investedSum  = Console.ReadLine();
            Decimal.TryParse(investedSum, out sum);

            Console.WriteLine("Enter the interest percentage.");
            string? interestPerYear = Console.ReadLine();
            Decimal.TryParse(interestPerYear, out interestPrc);

            Console.WriteLine("Enter the number of years which you would like to invest.");
            string? years = Console.ReadLine();
            int.TryParse(years, out nrOfYears);
    
            Console.WriteLine($"Year\tInvested Yearly\t\tInterest %\t\tInterest sum\t\ttotal");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            //calculate deposit with: yearly investment / interest percentage / number of years
            try {
                CalculateDeposit(sum, interestPrc, nrOfYears);
                Console.WriteLine($"Deposit calculated successfully.");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("'CalculateDeposit' encountered an issue, process aborted.");
                Console.WriteLine(ex.Message);
            }
            break;
        case 2:
            Console.WriteLine("6 Months Deposit.");

            Console.WriteLine("Enter the sum you want to invest into the deposit.");
            investedSum  = Console.ReadLine();
            Decimal.TryParse(investedSum, out sum);

            Console.WriteLine("Enter the interest percentage.");
            interestPerYear = Console.ReadLine();
            Decimal.TryParse(interestPerYear, out interestPrc);
            Calculate6MonthsDeposit(sum, interestPrc);
            break;
        case 3:
            Console.WriteLine("3 Months Deposit.");

            Console.WriteLine("Enter the sum you want to invest into the deposit.");
            investedSum  = Console.ReadLine();
            Decimal.TryParse(investedSum, out sum);

            Console.WriteLine("Enter the interest percentage.");
            interestPerYear = Console.ReadLine();
            Decimal.TryParse(interestPerYear, out interestPrc);
            Calculate3MonthsDeposit(sum, interestPrc);
            break;
        case 4:
            Console.WriteLine("1 Month Deposit.");

            Console.WriteLine("Enter the sum you want to invest into the deposit.");
            investedSum  = Console.ReadLine();
            Decimal.TryParse(investedSum, out sum);

            Console.WriteLine("Enter the interest percentage.");
            interestPerYear = Console.ReadLine();
            Decimal.TryParse(interestPerYear, out interestPrc);
            Calculate1MonthDeposit(sum, interestPrc);
            break;
        default:
            Console.WriteLine("Program exited successfully.");
            exit = true;
            break;
        }   
}


void CalculateDeposit(decimal investmentSumPerYear, decimal interestPercentage, int numberOfYears) {

    // to-do throw custom exceptions
    if(investmentSumPerYear <= 0 || interestPercentage <= 0 || numberOfYears <= 1)
    {
        throw new NullReferenceException("The value must be greater than 0.");
    }
    for(int year = 0; year <= numberOfYears; year++) {
        decimal interest = total * interestPercentage;
        total = total + (investmentSumPerYear + interest);

        Console.WriteLine($"{year}.\t{investmentSumPerYear:C}\t\t{interestPercentage:P2} per year.\t\t{interest:C2}\t\t\t{total:C}");
    }
}

void Calculate6MonthsDeposit(decimal investmentSum, decimal interestPercentage){
    decimal total6Months = 0.00m;
    if(investmentSum <= 0 || interestPercentage <= 0){
        throw new NullReferenceException("The value must be greater than 0.");
    }
    decimal interest = (investmentSum * interestPercentage) / 2;
    total6Months = total6Months + (investmentSum + interest);
    Console.WriteLine($"Invested: {investmentSum:C}\t\t{interestPercentage:P2} per year.\t\t{interest:C2}\t\t\t{total6Months:C}");
}

void Calculate3MonthsDeposit(decimal investmentSum, decimal interestPercentage) {
    decimal total3Months = 0.00m;
    if(investmentSum <= 0 || interestPercentage <= 0) {
        throw new NullReferenceException("The values must be greater than 0.");
    }
    decimal interest = (investmentSum * interestPercentage) / 4;
    total3Months = total3Months + (investmentSum + interest);
    Console.WriteLine($"Invested: {investmentSum:C}\t\t{interestPercentage:P2} per year.\t\t{interest:C2}\t\t\t{total3Months:C}");
}

void Calculate1MonthDeposit(decimal investmentSum, decimal interestPercentage) {
    decimal total1Month = 0.00m;
    if(investmentSum <= 0 || interestPercentage <= 0){
        throw new NullReferenceException("The value must be greater than 0.");
    }
    decimal interest = (investmentSum * interestPercentage) / 12;
    total1Month = total + (investmentSum + interest);
    Console.WriteLine($"Invested: {investmentSum:C}\t\t{interestPercentage:P2} per year.\t\t{interest:C2}\t\t\t{total1Month:C}");
}

void PrintMenu() {
    Console.WriteLine($"Deposit Console Application.(Fall 2024 v1)\n");
    Console.WriteLine("1.) Yearly Deposit. Work in progress");
    Console.WriteLine("2.) 6 Months Deposit. Work in progress.");
    Console.WriteLine("3.) 3 Months Deposit. Work in progress.");
    Console.WriteLine("4.) 1 Month Deposit. Work in progress.\n");
    Console.WriteLine("Press any key to exit the program.");
}


// void CalculateDeposit(decimal investmentSumPerYear, double interestPercentage, int numberOfYears) {

//     // to-do throw custom exceptions
//     if(investmentSumPerYear <= 0)
//     {
//         throw new NullReferenceException("investmentSumPerYear: The value must be greater than 0.");
//     }
//     for(int year = 0; year <= numberOfYears; year++) {
//         decimal interest = total * (decimal)interestPercentage;
//         total = total + (investmentSumPerYear + interest);

//         Console.WriteLine($"{year}.\t{investmentSumPerYear:C}\t\t{interestPercentage:P2} per year.\t\t{interest:C2}\t\t\t{total:C}");
//     }
// }



//to-do add an optional parameter ex also ron converter, by default it's gonna be just dollars
//to-do switch infinite menu with different types of deposits (1 year, 6 months ...);
//to-do exception handling





// for(int year = 0; year <= numberOfYears; year++) {
//     decimal interest = total * (decimal)interestPercentage;
//     total = total + (investmentSumPerYear + interest); // to-do need to add the interest
//     Console.WriteLine(
//         $"{year}.\t{investmentSumPerYear:C}\t\t{interestPercentage:P2} per year.\t\t{interest:C2}\t\t\t{total:C}"
//         );
// }
