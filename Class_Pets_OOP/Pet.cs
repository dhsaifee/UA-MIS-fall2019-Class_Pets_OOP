using System;
using System.Collections.Generic;
using System.Text;

namespace Pets
{
    class Pet
    {
        private int id;
        private string name;
        private string type;
        private double weight;
        static private int count;

        public Pet(int id, string name, string type, double weight)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.weight = weight;
        }

        public Pet()
        {

        }


        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }


        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }


        public new string GetType()
        {
            return type;
        }

        public void SetType(string type)
        {
            this.type = type;
        }


        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }


        public static int GetCount()
        {
            return count;
        }

        public static void SetCount(int count)
        {
            Pet.count = count;
        }

        public static void IncCount()
        {
            count++;
        }


        public int CompareTo(string name)
        {
            return this.name.CompareTo(name);
        }

        public int CompareTo(Pet myPet)
        {
            return name.CompareTo(myPet.GetName());
        }


        public override string ToString()
        {
            return id + "\t" + name + "\t" + type + "\t" + weight;
        }


        public string ToFile()
        {
            return id + "#" + name + "#" + type + "#" + weight;
        }


        public static void PrintPets(Pet[] myPets)
        {
            Console.WriteLine("\nID\tName\tType\tWeight");

            for (int i = 0; i < GetCount(); i++)
            {
                Console.WriteLine(myPets[i].ToString());
            }
        }

    }
}
