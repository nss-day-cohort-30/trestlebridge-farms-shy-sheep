using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseSeedAmount
    {
        public static void CollectInput(Farm farm, Sesame sesame)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine ("  1");
            Console.WriteLine ("  2");
            Console.WriteLine ("  3");
            Console.WriteLine ("  4");
            Console.WriteLine ("  5");
            Console.WriteLine ("  6");
            Console.WriteLine ("  7");
            Console.WriteLine();
            Console.WriteLine($"  How many rows of Sesame would you like to plant?");
            Console.Write ("> ");
            string choice = Console.ReadLine();
                       
        }

        public static void CollectInput(Farm farm, Sunflower sunflower)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine ("  1");
            Console.WriteLine ("  2");
            Console.WriteLine ("  3");
            Console.WriteLine ("  4");
            Console.WriteLine ("  5");
            Console.WriteLine ("  6");
            Console.WriteLine ("  7");
            Console.WriteLine();
            Console.WriteLine($"How many rows of Sunflowers would you like to plant?");
            Console.Write ("> ");
            string choice = Console.ReadLine();
        }

        public static void CollectInput(Farm farm, Wildflower wildflower)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine ("  1");
            Console.WriteLine ("  2");
            Console.WriteLine ("  3");
            Console.WriteLine ("  4");
            Console.WriteLine ("  5");
            Console.WriteLine ("  6");
            Console.WriteLine ("  7");
            Console.WriteLine();
            Console.WriteLine($"How many rows of Wildflowers would you like to plant?");
            Console.Write ("> ");
            string choice = Console.ReadLine();

        }
    }
}