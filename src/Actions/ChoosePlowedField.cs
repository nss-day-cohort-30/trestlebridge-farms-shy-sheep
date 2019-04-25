using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static bool UserTriedToSelectAFullFacility = false;


        public static void CollectInput(Farm farm, string seedChoice, int amountChoice)
        {
            Console.Clear();

            PlowedField anyFieldWithRoom = farm.PlowedFields.Find(pf => (pf.MaxCapacity - pf.CurrentCapacity) >= amountChoice);

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

                //user is buying multiple seeds so we need a list holding however many they want, then adding the list of resources to field which is on the farm

                List<ISeedProducing> plants = new List<ISeedProducing>();

                //determine which type of plant they want and then with for loop adding the appropriate amount(amountChoice parameter) to list of plants
            
                    for (int i = 0; i < amountChoice; i++)
                    {
                        plants.Add(new Sesame());
                    }
               

                //now we're adding the list of plants to the specific field that the user chose from the menu
                farm.PlowedFields[choice].AddResource(farm, plants);

                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(animal, choice);
            } //else if there isn't room for all the plants the user is trying to add, this else statement notifies user and takes to previous menu
            else
            {
                PurchaseSeed.ThereIsNoRoomForTheSeedBeingPurchased = true;
                Program.DisplayBanner();
                PurchaseSeed.CollectInput(farm);
            }

        }
    }
}