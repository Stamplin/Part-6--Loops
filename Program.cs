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

            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Menu Option 2");
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
                    Console.WriteLine("You chose Prompter");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
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

                        Console.ReadLine();

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
                                isBetween = true;
                            }
                            else
                            {
                                Console.WriteLine("The number " + num + " is not between " + min + " and " + max);
                                Console.WriteLine("Try again!!!!");
                            }
                        }

                        

                    }

                   

                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
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