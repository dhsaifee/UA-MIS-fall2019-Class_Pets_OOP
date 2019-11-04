using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Pets
{
    class PetFile
    {
        public static Pet[] ReadPetFile()
        {
            Pet[] myPets = new Pet[100];

            if (File.Exists("input.txt"))
            {
                StreamReader inFile = new StreamReader("input.txt");
                string line = inFile.ReadLine();
                while (line != null)
                {
                    string[] tempArray = line.Split('#');
                    myPets[Pet.GetCount()] = new Pet(int.Parse(tempArray[0]), tempArray[1], tempArray[2], double.Parse(tempArray[3]));

                    Pet.SetCount(Pet.GetCount() + 1);
                    line = inFile.ReadLine();
                }

                inFile.Close();
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            return myPets;
        }


        public static void WritepetFile(Pet[] myPets)
        {
            StreamWriter outFile = new StreamWriter("output.txt");

            for (int i = 0; i < Pet.GetCount(); i++)
            {
                outFile.WriteLine(myPets[i].ToFile());
            }

            outFile.Close();
        }


        // Sort pets by ID


    }
}
