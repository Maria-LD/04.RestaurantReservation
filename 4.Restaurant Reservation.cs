using System;

namespace RestaurantReservation
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number of people in the group: ");
                int people = int.Parse(Console.ReadLine());         //contains number of people in the group
                Console.Write("Enter the chosen package - \"Normal\", \"Gold\" or \"Platinum\": ");
                string package = Console.ReadLine().ToLower();

                string hall = "";           //appropriate hall
                double priceHall = 0;       //price of the appropriate hall

                //gives appropriate hall acoording to number of people
                if (people > 120)
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                    return;             //no need the whole program to be executed if people are more than 120
                }

                else if (people <= 50)
                {
                    hall = "Small Hall";
                    priceHall = 2500;
                }

                else if (people > 50 && people <= 100)
                {
                    hall = "Terrace";
                    priceHall = 5000;
                }

                if (people > 100 && people <= 120)
                {
                    hall = "Great Hall";
                    priceHall = 7500;
                }

                //calculate discount
                double pricePackage = 0;
                if (package == "normal")
                {
                    pricePackage = 500;
                    priceHall += pricePackage;
                    priceHall -= 0.05 * priceHall;
                }

                else if (package == "gold")
                {
                    pricePackage = 750;
                    priceHall += pricePackage;
                    priceHall -= 0.1 * priceHall;
                }

                else if (package == "platinum")
                {
                    pricePackage = 1000;
                    priceHall += pricePackage;
                    priceHall -= 0.15 * priceHall;
                }

                else
                {
                    Console.WriteLine("Your entry for the package is inappropriate! Please, start from the beginning!");
                    return;
                }

                Console.WriteLine($"We can offer you the \"{hall}\".");
                Console.WriteLine($"The price per person is ${(priceHall / people):F2}.");

            }
            catch
            {
                Console.WriteLine("Invalid input! Start filling the form from the beginning, please!");
            }
        }
    }
}