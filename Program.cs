using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6__Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            /*
            int age;

            Console.WriteLine("Please enter your age");
            while (!Int32.TryParse(Console.ReadLine(),out  age))
                Console.WriteLine("Invalid input");
            Console.ReadLine();
            */

            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my Epic and Cool menu B) \nPlease select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Bob's Simple Banking App");
                Console.WriteLine("...");
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                //Part 1 - prompter 
                if (choice == "1")
                {

                    //Do option 1
                    Console.Clear();
                    Console.WriteLine("You chose Prompter!!");
                    Thread.Sleep(500);

                    //fake loading animated to 3 dots
                    Console.WriteLine("Loading");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Loading.");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Loading..");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Loading...");
                    Thread.Sleep(1000);
                    Console.Clear();

                    //wait 1 second then proceed
                    Thread.Sleep(1000);
                    Console.Clear();

                    double min, max;
                    bool isBetween = false;
                    bool correctMinMax = false;

                    //MAKE SURE TO USE A LOOP FOR EVERYTHING!!!!!!

                    while (correctMinMax == false)
                    {
                        //ask user for min and max
                        Console.WriteLine("Please enter a minimum number");
                        min = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter a maximum number");
                        max = Convert.ToDouble(Console.ReadLine());

                        if (min > max)
                        {
                            Console.WriteLine("The minimum number must be less than the maximum number");
                        }
                        else
                        {
                            correctMinMax = true;
                        }

                        //ask user for a number between min and max and check if it's between it or not
                        while (isBetween == false)
                        {
                            Console.WriteLine("Please enter a number between " + min + " and " + max);
                            double num = Convert.ToDouble(Console.ReadLine());

                            //the check
                            if (num >= min && num <= max)
                            {
                                Console.WriteLine("The number " + num + " is between " + min + " and " + max);
                                Console.WriteLine("CORRECT!!!! GOOD BOY!!!!");
                                Thread.Sleep(2000);
                                isBetween = true;
                            }
                            else
                            {
                                Console.WriteLine("The number " + num + " is not between " + min + " and " + max);
                                Console.WriteLine("Try again!!!!");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                        }

                    }

                }
                else if (choice == "2")
                {
                    // Do option 2
                    //simple banking app
                    Console.Clear();
                    Console.WriteLine("You chose Simple Banking App");
                    Console.Clear();
                    Thread.Sleep(500);
                    //fake loading animated to 3 dots
                    Console.WriteLine("Loading");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Loading.");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Loading..");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Loading...");
                    Thread.Sleep(1000);
                    Console.Clear();

                    
                    //wait 1 second then proceed

                    Thread.Sleep(500);
                    Console.Clear();

                    double balance = 150;
                    double deposit = 0;
                    double withdraw = 0;
                    double billpayments = 0;
                    double accountbalance = 0;
                    double charge = 0.75;

                    bool bankopen = true;

                    string selection = "";

                    //if they chose invaid or any error make it charge 0.75 cents every time!!!

                    while (bankopen)
                    {
                        //title (maybe add text art later)
                        Console.WriteLine("Welcome to the Bank of Blorb.");
                        //current balance
                        Console.WriteLine("Current Balance: $" + balance);
                        Console.WriteLine();
                        //ask what u wanna do
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1 - Deposit");
                        Console.WriteLine("2 - Withdraw");
                        Console.WriteLine("3 - Bill Payments");
                        Console.WriteLine("4 - Account Balance");
                        Console.WriteLine("5 - Exit");

                        //user selects deposit
                        selection = Console.ReadLine();

                        if (selection == "1")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a deposit amount");
                            deposit = Convert.ToDouble(Console.ReadLine());
                            balance += deposit;
                            Console.Clear();
                            Thread.Sleep(500);
                            Console.WriteLine("Updated Balance: $" + balance);
                            //charge 0.75
                            balance -= charge;
                            Console.WriteLine("Transaction fee: $" + charge);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }

                        //user selects withdraw

                        else if (selection == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a withdraw amount");
                            withdraw = Convert.ToDouble(Console.ReadLine());

                            //check if user has enough money
                            bool invalidwit = false;
                            while (invalidwit == false)
                            {
                                if (withdraw > (balance - charge))
                                {
                                    Console.WriteLine("You do not have enough money to withdraw that amount");
                                    Console.WriteLine("Service fee deducted: $" + charge + " Try again.");
                                    balance -= charge;
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                    Console.WriteLine("Please enter a withdraw amount");
                                    withdraw = Convert.ToDouble(Console.ReadLine());
                                }
                                else
                                {
                                    invalidwit = true;
                                }
                            }

                            //math part
                            balance -= withdraw;
                            //print receipt kinda thing
                            Console.Clear();
                            Thread.Sleep(500);
                            Console.WriteLine("Updated Balance: $" + balance);
                            //charge 0.75
                            balance -= charge;
                            Console.WriteLine("Transaction fee: $" + charge);
                            Thread.Sleep(1000);
                            Console.Clear();

                        }

















                        ////select deposit
                        //selection = Console.ReadLine();

                        //if (selection == "1")
                        //{
                        //    Console.WriteLine("Please enter a deposit amount");
                        //    deposit = Convert.ToDouble(Console.ReadLine());
                        //    balance += deposit;
                        //    Console.Clear();
                        //    Thread.Sleep(500);
                        //    Console.WriteLine("Updated Balance: $" + balance);
                        //    //charge 0.75
                        //    balance -= charge;
                        //    Console.WriteLine("Transaction fee: $" + charge);
                        //    Thread.Sleep(1500);
                        //    Console.Clear();
                        //}




                        //bool enoughmoney = false;



                        ////select withdraw
                        //if (selection == "2")
                        //{
                        //    Console.WriteLine("Please enter a withdraw amount");
                        //    withdraw = Convert.ToDouble(Console.ReadLine());
                        //    balance -= withdraw;
                        //    Console.Clear();
                        //    Thread.Sleep(500);
                        //    Console.WriteLine("Updated Balance: $" + balance);
                        //    //charge 0.75
                        //    balance -= charge;
                        //    Console.WriteLine("Transaction fee: $" + charge);
                        //    Thread.Sleep(1500);
                        //    Console.Clear();

                        //    while (enoughmoney == false)
                        //    {
                        //        if (balance < withdraw)
                        //        {
                        //            Console.WriteLine("You do not have enough money to withdraw that amount.");
                        //            Console.WriteLine("Please try again.");
                        //            Console.WriteLine();
                        //            Console.WriteLine("Press ENTER to continue.");
                        //            Console.ReadLine();
                        //            Console.Clear();
                        //            //charge 0.75
                        //            balance -= charge;
                        //            Console.WriteLine("Transaction fee: $" + charge);
                        //            Thread.Sleep(1500);
                        //            Console.Clear();
                        //        }
                        //        else
                        //        {
                        //            enoughmoney = true;
                        //        }
                        //    }

                        //}

                        ////select bill payments
                        //else if (selection == "3")
                        //{
                        //    Console.WriteLine("Please enter a bill payments amount");
                        //    billpayments = Convert.ToDouble(Console.ReadLine());
                        //    balance -= billpayments;
                        //    Console.Clear();
                        //    Thread.Sleep(500);
                        //    Console.WriteLine("Updated Balance: $" + balance);
                        //    //charge 0.75
                        //    balance -= charge;
                        //    Console.WriteLine("Transaction fee: $" + charge);
                        //    Thread.Sleep(1500);
                        //    Console.Clear();
                        //}

                        //////select account balance
                        ////else if (selection == "4")
                        ////{
                        ////    Console.WriteLine("Account Balance: $" + balance);
                        ////    //charge 0.75
                        ////    balance -= charge;
                        ////    Console.WriteLine("Transaction fee: $" + charge);
                        ////    Console.WriteLine();
                        ////    Console.WriteLine("Updated Balance: $" + balance);
                        ////    Console.WriteLine();
                        ////    Console.WriteLine("Press ENTER to continue.");
                        ////    Console.Clear();

                        ////}
                        //else if (selection == "5")
                        //{
                        //    bankopen = false;
                        //}


                        ////if any error charge 0.75
                        //else if (Console.ReadLine() != "1" && Console.ReadLine() != "2" && Console.ReadLine() != "3" && Console.ReadLine() != "4")
                        //{
                        //    Console.WriteLine("Invalid choice, service fee deducted.");
                        //    balance -= charge;
                        //    Console.WriteLine("Transaction fee: $" + charge);
                        //    Thread.Sleep(1500);
                        //    Console.Clear();
                        //}





                    }


                }
                // Add an else if for each valid choice...
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}