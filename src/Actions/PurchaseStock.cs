using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class PurchaseStock {
        private const int V = 2;

        public static bool ThereIsNoRoomForTheAnimalBeingPurchased = false;
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Cow");
            Console.WriteLine ("2. Ostrich");
            Console.WriteLine ("3. Duck");
            Console.WriteLine ("4. Goat");
            Console.WriteLine ("5. Pig");
            Console.WriteLine ("6. Sheep");
            Console.WriteLine ("7. Chicken");
            Console.WriteLine ("8. Go Back To Main Menu");


            Console.WriteLine ();
            if (ThereIsNoRoomForTheAnimalBeingPurchased)
            {
                Console.WriteLine("Sorry, but you don't have anywhere to put that animal. Please make a different selection.");
            }

            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                case 2:
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    break;
                case 3:
                    ChooseDuckHouse.CollectInput(farm, new Duck());
                    break;
                case 4:
                    ChooseGrazingField.CollectInput(farm, new Goat());
                    break;
                case 5:
                    ChooseGrazingField.CollectInput(farm, new Pig());
                    break;
                case 6:
                    ChooseGrazingField.CollectInput(farm, new Sheep());
                    break;
                case 7:
                    ChooseChickenHouse.CollectInput(farm, new Chicken());
                    break;
                case 8:
                    break;
                default:
                    break;
            }
        }
    }
}