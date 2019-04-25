using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseSeed
    {
        public static bool ThereIsNoRoomForTheSeedBeingPurchased = false;
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine(" 1. Sesame");
            Console.WriteLine(" 2. Sunflower");
            Console.WriteLine(" 3. Wildflower");

            Console.WriteLine();
               if (ThereIsNoRoomForTheSeedBeingPurchased)
            {
                Console.WriteLine("Sorry, but you don't have anywhere to put that seed. Please make a different selection.");
            }

            Console.WriteLine("  Choose seed to purchase");

            Console.Write("> ");
            string seedChoice = Console.ReadLine();

            if (seedChoice == "1")
            {

                seedChoice = "Sesame";

            }

            if (seedChoice == "2")
            {

                seedChoice = "Sunflower";

            }

            if (seedChoice == "3")
            {

                seedChoice = "Wildflower";

            }

            Console.WriteLine($"  How many {seedChoice} would you like to plant?");

            int amountChoice = Int32.Parse(Console.ReadLine());

            if (seedChoice == "Sesame")
            {
                ChoosePlowedField.CollectInput(farm, seedChoice, amountChoice);
            }
            // if (seedChoice == "Sunflower")
            // {
            //     ChoosePlowedOrNaturalField.CollectInput(farm, seedChoice, amountChoice);
            // }
            if (seedChoice == "Wildflower")
            {
                ChooseNaturalField.CollectInput(farm, seedChoice, amountChoice);
            }


        }
    }
}