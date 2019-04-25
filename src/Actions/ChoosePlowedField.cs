using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static bool UserTriedToSelectAFullFacility = false;


        public static void CollectInput(Farm farm, string seedChoice, int amountChoice)
        {
            Console.Clear();

            PlowedField anyFieldWithRoom = farm.PlowedFields.Find(pf => pf.CurrentCapacity < pf.MaxCapacity);

            if (anyFieldWithRoom != null)
            {
                for (int i = 0; i < farm.PlowedFields.Count; i++)
                {
                    PlowedField currentField = farm.PlowedFields[i];
                    Console.WriteLine($"{i + 1}. Plowed field - {currentField.CurrentCapacity} of {currentField.MaxCapacity} rows of plants\n");
                }

                Console.WriteLine();

                // How can I output the type of plant chosen here?
                if (UserTriedToSelectAFullFacility)
                {
                    Console.WriteLine("That field does not have enough room.");
                }
                Console.WriteLine($"Place the plants where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine()) - 1;

                farm.PlowedFields[choice].AddResource(farm, plant);

                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(animal, choice);
            }
              else
            {
                PurchaseSeed.ThereIsNoRoomForTheSeedBeingPurchased = true;
                Program.DisplayBanner();
                PurchaseSeed.CollectInput(farm);
            }

        }
    }
}