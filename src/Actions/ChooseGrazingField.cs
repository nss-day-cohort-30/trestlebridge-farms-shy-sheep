using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChooseGrazingField {
        public static bool UserTriedToSelectAFullFacility = false;

        public static void CollectInput (Farm farm, IGrazing animal) {
            Console.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                GrazingField currentField = farm.GrazingFields[i];
                Console.WriteLine ($"{i + 1}. Grazing field - {currentField.CurrentCapacity} of {currentField.Capacity} animals\n");
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            if (UserTriedToSelectAFullFacility)
            {
                Console.WriteLine("That facility is already full.");
            }
            Console.WriteLine ($"Place the animal where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ()) - 1;

            farm.GrazingFields[choice].AddResource(farm, animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }

    }
}