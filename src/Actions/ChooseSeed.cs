using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChooseSeed {
        public static void CollectInput (Farm farm, IGrazing animal) {
       
            // Console.WriteLine($"How many {choice} would you like to plant?")

            // for (int i = 0; i < farm.GrazingFields.Count; i++)
            // {
            //     Console.WriteLine ($"{i + 1}. Grazing Field");
            // }

            // Console.WriteLine ();

            // // How can I output the type of animal chosen here?
            // Console.WriteLine ($"Place the animal where?");

            // Console.Write ("> ");
            // int choice = Int32.Parse(Console.ReadLine ()) - 1;

            // farm.GrazingFields[choice].AddResource(animal);


        }
    }
}