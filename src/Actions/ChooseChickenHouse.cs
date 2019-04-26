using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static bool UserTriedToSelectAFullFacility = false;
        public static void CollectInput(Farm farm, Chicken chicken)
        {
            Console.Clear();

            ChickenHouse anyHouseWithRoom = farm.ChickenHouses.Find(ch => ch.CurrentCapacity < ch.MaxCapacity);

            if (anyHouseWithRoom != null)
            {

                for (int i = 0; i < farm.ChickenHouses.Count; i++)
                {
                    ChickenHouse currentHouse = farm.ChickenHouses[i];
                    if (currentHouse.CurrentCapacity < currentHouse.MaxCapacity)
                    {
                        Console.WriteLine($"{i + 1}. {currentHouse}");
                    }
                }

                Console.WriteLine();

                // How can I output the type of plant chosen here?
                if (UserTriedToSelectAFullFacility)
                {
                    Console.WriteLine("That facility is already full.");
                }
                Console.WriteLine($"Place the Chicken where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine()) - 1;

                farm.ChickenHouses[choice].AddResource(farm, chicken);
            }
            else
            {
                PurchaseStock.ThereIsNoRoomForTheAnimalBeingPurchased = true;
                Program.DisplayBanner();
                PurchaseStock.CollectInput(farm);
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}