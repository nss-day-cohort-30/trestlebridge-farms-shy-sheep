using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChooseChickenHouse {
        public static void CollectInput (Farm ChickenHouse, IChicken chicken) {
            Console.Clear();

            for (int i = 0; i < ChickenHouse.ChickenFeeds.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Chicken House");
            }

            Console.WriteLine ();

            // How can I output the type of Chicken chosen here?
            Console.WriteLine ($"Place the Chicken where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ()) - 1;

            ChickenHouse.ChickenFeeds[choice].AddResource(chicken);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }

        internal static void CollectInput(Farm farm, Chicken chicken)
        {
            throw new NotImplementedException();
        }
    }
}