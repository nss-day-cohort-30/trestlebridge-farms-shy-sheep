using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChooseNaturalField {
        public static bool UserTriedToSelectAFullFacility = false;

        public static void CollectInput (Farm farm, ICompostProducing plant) {
            Console.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                NaturalField currentField = farm.NaturalFields[i];
                Console.WriteLine ($"{i + 1}. Natural field - {currentField.CurrentCapacity} of {currentField.Capacity} rows of plants\n");
            }

            Console.WriteLine ();

            // How can I output the type of plant chosen here?
            if (UserTriedToSelectAFullFacility)
            {
                Console.WriteLine("That facility is already full.");
            }
            Console.WriteLine ($"Place the plants where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ()) - 1;

            farm.NaturalFields[choice].AddResource(farm, plant);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}