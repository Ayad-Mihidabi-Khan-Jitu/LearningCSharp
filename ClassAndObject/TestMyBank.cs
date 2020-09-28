using System;

namespace ProjectsOfClassesAndObjects
    {
    /*
     A customer opens an account in a bank, the customer must have an initial balance of 100tk
     while opening the account, the customer can withdraw, deposite and check his balance any time
    He wants , the bank does nt charge any fees for the first withdrewal but for all subseqent withdrawal,
     on the amount deposited by the customer as per its interest rate.
     */
    class TestMyBank
    { 
        static void Main(string[] args)
        {
            string inputs;
            int input;
            int numberOfCustomers = 0;
            Bank bank = new Bank();
            Customer[] cus = bank.getCustomer(); 
            while (true)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Please Enter Your Choice");
                Console.WriteLine("1 : Add Customers");
                Console.WriteLine("2 : Deposite Money");
                Console.WriteLine("3 : Withdraw Money");
                Console.WriteLine("4 : Check Balance");
                Console.WriteLine("5 : Calculate Interest");
                Console.WriteLine("0 : Exit");
                Console.WriteLine("---------------------------------");
                string iniAccontName;
                inputs = Console.ReadLine();
                input = Convert.ToInt32(inputs);
                if (input == 0) System.Environment.Exit(0);
                else if (input == 1)
                {//Add Customers
                    Console.WriteLine("Creating a new account for a new customer");
                    Console.WriteLine("_________________________________________");
                    Console.Write("Please Enter your account number : ");
                    string iniAccontNumber = Console.ReadLine();
                    Console.Write("Please Enter initial Balance in your account : ");
                    string balance = Console.ReadLine();
                    double iniBalance = Convert.ToInt32(balance);
                    Account account = new Account(iniAccontNumber, iniBalance);
                    Console.Write("Please Enter your Name : ");
                    iniAccontName = Console.ReadLine();
                    Customer customer = new Customer(iniAccontName, account);
                    cus[numberOfCustomers] = customer;
                    numberOfCustomers++;
                    Console.WriteLine("NUMBER OF CUSTOMERS " + numberOfCustomers);
                    for (int i = 0; i < numberOfCustomers; i++)
                    {
                        Console.WriteLine("Name of customer no.  " + (i + 1) + " : " + cus[i].getName());
                    }

                }
                else if (input == 2)
                {//Deposite Money
                    if (numberOfCustomers == 0)
                    {
                        Console.WriteLine("No Customers in this Bank yet");
                    }
                    else
                    {
                        bool ckAcc = false;
                        Console.Write("Enter the Account Number : ");
                        iniAccontName = Console.ReadLine();
                        for (int i = 0; i < numberOfCustomers; i++)
                        {
                            Account tempacc = cus[i].getAccount();
                            string accname = tempacc.getAccountNumber();
                            if (iniAccontName==accname)
                            {
                                Console.Write("Enter the amount you want to deposite : ");
                                double dpmoney = Convert.ToDouble(Console.ReadLine());
                                tempacc.deposite(dpmoney);
                                ckAcc = true;
                            }

                        }
                        if (!ckAcc)
                        {
                            Console.WriteLine("No Account Found");
                        }
                    }
                }
                else if (input == 3)
                {//Withdraw Money"
                    if (numberOfCustomers == 0)
                    {
                        Console.WriteLine("No Customers in this Bank yet");
                    }
                    else
                    {
                        bool ckAcc = false;
                        Console.Write("Enter the Account Number : ");
                        iniAccontName = Console.ReadLine();
                        for (int i = 0; i < numberOfCustomers; i++)
                        {
                            Account tempacc = cus[i].getAccount();
                            string accname = tempacc.getAccountNumber();
                            if (iniAccontName == accname)
                            {
                                Console.Write("Enter the amount you want to withdraw : ");
                                double wdmoney = Convert.ToDouble(Console.ReadLine());
                                tempacc.withdraw(wdmoney);
                                ckAcc = true;
                            }

                        }
                        if (!ckAcc)
                        {
                            Console.WriteLine("No Account Found");
                        }
                    }

                }
                else if (input == 4)
                {//Check Balance
                    if (numberOfCustomers == 0)
                    {
                        Console.WriteLine("No Customers in this Bank yet");
                    }
                    else
                    {
                        bool ckAcc = false;
                        Console.Write("Enter the Account Number : ");
                        iniAccontName = Console.ReadLine();
                        for (int i = 0; i < numberOfCustomers; i++)
                        {
                            Account tempacc = cus[i].getAccount();
                            string accname = tempacc.getAccountNumber();
                            if (iniAccontName == accname)
                            {
                                tempacc.getBalance();
                                ckAcc = true;
                            }

                        }
                        if (!ckAcc)
                        {
                            Console.WriteLine("No Account Found");
                        }
                    }


                }
                else if (input == 5)
                {//Calculate Interest
                    if (numberOfCustomers == 0)
                    {
                        Console.WriteLine("No Customers in this Bank yet");
                    }
                    else
                    {
                        bool ckAcc = false;
                        Console.Write("Enter the Account Number : ");
                        iniAccontName = Console.ReadLine();
                        for (int i = 0; i < numberOfCustomers; i++)
                        {
                            Account tempacc = cus[i].getAccount();
                            string accname = tempacc.getAccountNumber();
                            if (iniAccontName == accname)
                            {
                                bank.calculateInterest(cus[i]);
                                ckAcc = true;
                            }

                        }
                        if (!ckAcc)
                        {
                            Console.WriteLine("No Account Found");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Please put any valid input");
                }
                Console.WriteLine();
            }
        }
    }
}
