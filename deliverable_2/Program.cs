using System;

namespace deliverable_1
{
    class Program
    {
        public static void Main(string[] args) {
                double price = 9.99;
                double coffee = 2.00;
                double partytotal = 0;
                int watercount = 0;
                int coffeecount = 0;
                Console.Write("Hi. Welcome to our Buffet.All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.\n");
                int partysize = int.Parse(Console.ReadLine());
                if (partysize > 6) {
                    Console.WriteLine("Sorry, but you should follow the rules. GOODBYE!");
                }
                else {
                    partytotal = partytotal + (price * partysize);
                    Console.WriteLine("\nA table for " + partysize + " Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or coffee.\n");
                    for (int i = 1; i <= partysize; i++) {
                        Console.WriteLine("\nOk, person " + i + " Do you want water or coffee?\n");
                        string choice = Console.ReadLine();
                        if (choice == "water") {
                            Console.WriteLine("\nWater, good choice!");
                            watercount++;
                        }
                        else if (choice == "coffee") {
                            partytotal += coffee;
                            coffeecount++;
                            Console.WriteLine("\nCoffee, very tasty!");
                        } else {
                            Console.WriteLine("\nWhat did you just say? that doesn't exist. Moving on...");
                        }   
                    }
                Console.WriteLine("\nOk, so that's " + coffeecount + " coffee(s), and " + watercount + " water(s).");
                    Console.WriteLine("\nAwesome, here is your total!");
                    Console.WriteLine(partytotal);
                }
        }
    }
}

