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
    public class ChooseSunflowerField
    {
        public static bool UserTriedToSelectAFullFacility = false;


        public static void CollectInput(Farm farm, string seedChoice, int amountChoice)
        {
            Console.Clear();

            //     //anything that is of type object can be put in this list
            //     List<object> sunflowerFields = new List<object>();

            //     farm.PlowedFields.ForEach(pf => {

            //     //cast from type PlowedField to type object
            //     object transformedField = pf as object;
            //     sunflowerFields.Add(transformedField);
            //     });

            //   farm.NaturalFields.ForEach(nf => {

            //     //cast from type PlowedField to type object
            //     object transformedField = nf as object;
            //     sunflowerFields.Add(transformedField);
            //     });




            NaturalField anyNaturalFieldWithRoom = farm.NaturalFields.Find(nf => (nf.MaxCapacity - nf.CurrentCapacity) >= amountChoice);
            PlowedField anyPlowedFieldWithRoom = farm.PlowedFields.Find(pf => (pf.MaxCapacity - pf.CurrentCapacity) >= amountChoice);

            if (anyNaturalFieldWithRoom != null || anyPlowedFieldWithRoom != null)
            {
                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {
                    NaturalField currentField = farm.NaturalFields[i];
                    Console.WriteLine($"{i + 1}. Natural field - {currentField.CurrentCapacity} of {currentField.MaxCapacity} rows of plants\n");
                }

                for (int i = 0; i < farm.PlowedFields.Count; i++)
                {
                    PlowedField currentField = farm.PlowedFields[i];
                    //this allows the plowed fields to be displayed after the available natural fields
                    Console.WriteLine($"{i + farm.NaturalFields.Count + 1}. Plowed field - {currentField.CurrentCapacity} of {currentField.MaxCapacity} rows of plants\n");
                }

                Console.WriteLine();

                // How can I output the type of plant chosen here?
                if (UserTriedToSelectAFullFacility)
                {
                    Console.WriteLine("That field does not have enough room.");
                }
                Console.WriteLine($"Place the plants where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                //user is buying multiple seeds so we need a list holding however many they want, then adding the list of resources to field which is on the farm

                //if their choice is a number greater than Natural Fields count, then they are choosing a plowed field
                if (choice > farm.NaturalFields.Count)
                {
                    List<ISeedProducing> plants = new List<ISeedProducing>();

                    //determine which type of plant they want and then with for loop adding the appropriate amount(amountChoice parameter) to list of plants

                    for (int i = 0; i < amountChoice; i++)
                    {
                        plants.Add(new Sunflower());
                    }




                    //now we're adding the list of plants to the specific field that the user chose from the menu
                    //choice(user input) - farm.NaturalFields.Count (number of natural fields listed) - 1 (bc index starts from 0 not 1)
                    PlowedField target = farm.PlowedFields[choice - farm.NaturalFields.Count - 1];

                    if (target.MaxCapacity - target.CurrentCapacity >= amountChoice)
                    {
                        farm.PlowedFields[choice - 1 - farm.NaturalFields.Count].AddResource(farm, plants);
                        ChooseSunflowerField.UserTriedToSelectAFullFacility = false;
                    }
                    else
                    {
                        UserTriedToSelectAFullFacility = true;
                        ChooseSunflowerField.CollectInput(farm, seedChoice, amountChoice);
                    }

                    //make sure that this variable is set to false, in case user was previous directed
                    PurchaseSeed.ThereIsNoRoomForTheSeedBeingPurchased = false;
                }
                else
                {
                    List<ICompostProducing> plants = new List<ICompostProducing>();

                    //determine which type of plant they want and then with for loop adding the appropriate amount(amountChoice parameter) to list of plants

                    NaturalField target = farm.NaturalFields[choice - 1];
                    if (target.MaxCapacity - target.CurrentCapacity >= amountChoice)
                    {

                        for (int i = 0; i < amountChoice; i++)
                        {
                            plants.Add(new Sunflower());
                        }



                        //now we're adding the list of plants to the specific field that the user chose from the menu
                        //choice(user input) - 1 (bc index starts from 0 not 1)
                        target.AddResource(farm, plants);

                        //make sure that this variable is set to false, in case user was previous directed
                        PurchaseSeed.ThereIsNoRoomForTheSeedBeingPurchased = false;
                        UserTriedToSelectAFullFacility = false;

                    }
                    else
                    {
                        UserTriedToSelectAFullFacility = true;
                        ChooseSunflowerField.CollectInput(farm, seedChoice, amountChoice);
                    }
                }

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