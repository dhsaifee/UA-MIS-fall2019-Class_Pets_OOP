using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet[] myPets = PetFile.ReadPetFile();

            CreateMenu(myPets);

            Console.ReadKey();

        }


        public static void CreateMenu(Pet[] myPets)
        {
            int menuChoice = GetMenuChoice();

            if (menuChoice == 5)
            {
                Console.WriteLine("Good Bye!!!");
            }

            while (menuChoice !=5)
            {
                if (menuChoice == 1)
                {
                    Console.WriteLine("You chose to print the data on the pets.");
                    Pet.PrintPets(myPets);
                }
                else if (menuChoice == 2)
                {
                    Console.WriteLine("You chose to view the average weight of the pets.");
                    Report.AverageWeight(myPets);
                }
                else if (menuChoice == 3)
                {
                    Console.WriteLine("You chose to view the pairs of pets with combined weight over 50 pounds.");
                    Report.CombinedWeightOver50(myPets);
                }
                else
                {
                    Console.WriteLine("You chose to view the average weight of the pets by their type.");
                    // Call the method to display the average weight by type
                }

                menuChoice = GetMenuChoice();

                if (menuChoice == 5)
                {
                    Console.WriteLine("Good Bye!!!");
                }
            }
        }


        public static int GetMenuChoice()
        {
            int choice;
            bool notValid = true;

            Console.WriteLine("\n\nMenu options:\n" +
                "1 to print the data on the pets\n" +
                "2 to view the average weight of the pets\n" +
                "3 to view the pairs of pets with combined weight over 30 pounds\n" +
                "4 to view the average weight of the pets by their type\n" +
                "5 to exit the menu");
            Console.Write("Please enter a menu choice: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out choice))
            {
                if (choice >= 1 && choice <= 5)
                {
                    notValid = false;
                }
            }

            while (notValid)
            {
                Console.Write("Please enter a valid menu choice: ");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out choice))
                {
                    if (choice >= 1 && choice <= 5)
                    {
                        notValid = false;
                    }
                }
            }

            return choice;
        }

    }
}
