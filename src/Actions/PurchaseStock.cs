using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class PurchaseStock {
        private const int V = 2;

        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Cow");
            Console.WriteLine ("2. Ostrich");
            Console.WriteLine ("3. Duck");
            Console.WriteLine ("4. Goat");
            Console.WriteLine ("5. Pig");
            Console.WriteLine ("6. Sheep");
            Console.WriteLine ("7. Chicken");


            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse(choice))
            {
                case 1:
                ChooseGrazingField.CollectInput(farm, new Cow());
                break;
                default:
                    break;
            }
        }
    }
}