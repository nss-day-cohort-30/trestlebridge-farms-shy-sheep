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
            Console.WriteLine($"How many rows of Sesame would you like to plant?");
            Console.ReadLine();
        }

        public static void CollectInput(Farm farm, Sunflower sunflower)
        {
            Console.Clear();
            Console.WriteLine($"How many rows of Sunflowers would you like to plant?");
            Console.ReadLine();
        }

        public static void CollectInput(Farm farm, Wildflower wildflower)
        {
            Console.Clear();
            Console.WriteLine($"How many rows of Wildflowers would you like to plant?");
            string choice = Console.ReadLine();
            //        switch (Int32.Parse(choice))
            // // {
            // //     case 1:
            // //         ChoosingField.CollectInput(farm, new Cow());
            // //         break;
            // //     default:
            // //         break;
            // // }
            // }


        }
    }
}