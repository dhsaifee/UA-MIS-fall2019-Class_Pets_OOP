using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Pets
{
    class Report
    {
        public static void AverageWeight(Pet[] myPets)
        {
            Console.WriteLine();

            StreamWriter outFile = new StreamWriter("average_weight.txt");

            double total = 0;

            for (int i = 0; i < Pet.GetCount(); i++)
            {
                total += myPets[i].GetWeight();
            }
            
            Console.WriteLine("The average weight of the pets is: " + Math.Round(total / Pet.GetCount(), 2) + " lbs");
            outFile.WriteLine("The average weight of the pets is: " + Math.Round(total / Pet.GetCount(), 2) + " lbs");

            outFile.Close();
        }


        public static void CombinedWeightOver50(Pet[] myPets)
        {
            Console.WriteLine();

            for (int i = 0; i < Pet.GetCount() - 1; i++)
            {
                for (int j = i + 1; j < Pet.GetCount(); j++)
                {
                    if (myPets[i].GetWeight() + myPets[j].GetWeight() > 50)
                    {
                        Console.WriteLine(myPets[i].GetId() + " " + myPets[i].GetName() + ":" + myPets[i].GetWeight() + "lbs"
                            + "\t" + myPets[j].GetId() + " " + myPets[i].GetName() + ": " + myPets[j].GetWeight() + "lbs");
                    }
                }
            }
        }


        // Method definition for claclulating and displaying the averge weight of the pets by type
        public static void AvgWeightByType(Pet[] myPets)
        {
            string currentType = myPets[0].GetType();
            int currentCount = 1;
            double totalWeight = myPets[0].GetWeight();

            StreamWriter outFile = new StreamWriter("avg_weight_by_type.txt");

            for(int i = 1; i < Pet.GetCount(); i++)
            {
                if(currentType == myPets[i].GetType())
                {
                    currentCount++;
                    totalWeight += myPets[i].GetWeight();
                }
                else
                {
                    Console.WriteLine("The average weight of "
                        + currentType + " is: " + (totalWeight / currentCount));
                    outFile.WriteLine("The average weight of "
                        + currentType + " is: " + (totalWeight / currentCount));

                    currentType = myPets[i].GetType();
                    currentCount = 1;
                    totalWeight = myPets[i].GetWeight();
                }
            }
            Console.WriteLine("The average weight of "
                        + currentType + " is: " + (totalWeight / currentCount));
            outFile.WriteLine("The average weight of "
                        + currentType + " is: " + (totalWeight / currentCount));
            outFile.Close();
        }
    }
}
