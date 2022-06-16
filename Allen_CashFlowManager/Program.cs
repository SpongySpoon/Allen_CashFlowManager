// See https://aka.ms/new-console-template for more information

//Cody Allen
// IT112 
// NOTES: Program works but if you use hourly or salaried employee, the program will ask you for
// three unecessary inputs before the program loops back to the top.
// BEHAVIORS NOT IMPLEMENTED AND WHY: All behaviors were implemented correctly.

using Allen_CashFlowManager;

int userInput;

Random s = new Random(DateTime.Now.Millisecond);
int Invoice1 = s.Next(100, 9000);
int Invoice2 = s.Next(100, 9000);

Ledger ledger = new Ledger();

IPayable[] payMe = new IPayable[10];

bool bloop = true;

payMe[0] = new HourlyEmployee(" Karen ", " Williams ", " 4444-44-4444 ", 670.00m, 40);
payMe[1] = new HourlyEmployee(" Carol ", " Walsh ", " 333-33-3333 ", 838.50m, 42);
payMe[2] = new SalariedEmployee(" John ", " Smith ", " 111-11-1111 ", 800.50m);
payMe[3] = new SalariedEmployee(" Susan ", " Mathews ", " 222-22-2222 ", 1110.00m);
payMe[4] = new Invoice(" 128_9845 ", " Flux Capacitor ", 2, 3655.66m, 266351, 2536);
payMe[5] = new Invoice(" 5787_7364 ", " Flux Capacitor ", 3, 14.50m, 676677, 5467);


while (bloop)
{
    Console.WriteLine("Choose an option: ");
    Console.WriteLine("1) Hourly employee: ");
    Console.WriteLine("2) Salaried Employee: ");
    Console.WriteLine("3) Invoice: ");
    Console.WriteLine("4) Total amount/Exit: ");
      

    for (int g = 6; g < payMe.Length; g++)
    {
         userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
        {
            Console.WriteLine("First name: \n");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("SSN: ");
            string SSN = Console.ReadLine();
            Console.WriteLine("Hourly Pay: ");
            decimal hourlyPay = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked: ");
            int hoursWorked = int.Parse(Console.ReadLine());

            payMe[g] = new HourlyEmployee(FirstName, LastName, SSN, hourlyPay, hoursWorked);
            
        }
        else if (userInput == 2)
        {
            Console.WriteLine("First name: \n");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("SSN: ");
            string SSN = Console.ReadLine();
            Console.WriteLine("Salary: ");
            decimal Salary = decimal.Parse(Console.ReadLine());

            payMe[g] = new SalariedEmployee(FirstName, LastName, SSN, Salary);

        }
        else if (userInput == 3)
        {
            Console.WriteLine("What is the part number? \n");
            string partNumber = Console.ReadLine();
            Console.WriteLine("Part Description?");
            string partDescription = Console.ReadLine();
            Console.WriteLine("Quantity?");
            int Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Price? ");
            decimal Price = decimal.Parse(Console.ReadLine());

            payMe[g] = new Invoice(partNumber, partDescription, Quantity, Price, Invoice1, Invoice2);
        }

        else if (userInput == 4)
        {
            bloop = false;
            foreach (IPayable payable in payMe)
            {
                if (payable == null)
                {
                    break;
                }
                else
                {

                    
                        if (payable.GetLedgerType == Ledger.LedgerType.Hourly)
                        {
                            ledger.sethourlyTotal(payable.GetPayableAmount);
                        }
                        else if (payable.GetLedgerType == Ledger.LedgerType.Salaried)
                        {
                            ledger.setInvoiceTotal(payable.GetPayableAmount);
                        }
                        else if (payable.GetLedgerType == Ledger.LedgerType.Invoice)
                        {
                            ledger.setSalaryTotal(payable.GetPayableAmount);
                        }

                        Console.WriteLine(payable.ToString());
                       
                        



                    
                }
                

            }
            Console.WriteLine("Total amount payable: " + ledger.getTotalamount);
            Console.WriteLine("Total hours payable:" + ledger.gethourlyTotal);
            Console.WriteLine("Total salary payable:" + ledger.getSalaryTotal);
            Console.WriteLine("Total invoice payable: " + ledger.getinvoiceTotal);
            Environment.Exit(0);
            
        }        
    }
}





