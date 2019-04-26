using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<Duck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<Duck> _animals = new List<Duck>();

        public double MaxCapacity
        {
            get
            {
                return _capacity;
            }
        }

        public double CurrentCapacity
        {
            get
            {
                return _animals.Count;
            }
        }

        public void AddResource(Farm farm, Duck animal)
        {
            if (_animals.Count < _capacity)
            {
                _animals.Add(animal);
                ChooseDuckHouse.UserTriedToSelectAFullFacility = false;
            }
            else
            {
                ChooseDuckHouse.UserTriedToSelectAFullFacility = true;
                ChooseDuckHouse.CollectInput(farm, animal);
            }
        }

        public void AddResource(Farm farm, List<Duck> animals)
        {

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            // StringBuilder animalSummary = new StringBuilder();

            //put each animal summary (12 cow) into this List so we can use Join to join them with commas between but not have one at the end
            List<string> animalSummary = new List<string>();
            Dictionary<string, int> totalAnimalCounts = new Dictionary<string, int>();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            _animals.ForEach(animal => {
                //Type property is inaccessible on animal because it is currently Type IGrazing
                //Cast (change from one type to another) to Type IResource so it becomes available
                IResource castAnimal = (IResource)animal;
                if (!totalAnimalCounts.ContainsKey(castAnimal.Type))
                {
                    totalAnimalCounts[castAnimal.Type] = 1;
                }
                else
                {
                    totalAnimalCounts[castAnimal.Type] += 1;
                }
            });

             foreach (KeyValuePair<string, int> animalCount in totalAnimalCounts)
             {
                //  animalSummary.Append($"{animalCount.Value} {animalCount.Key},");
                 animalSummary.Add($"{animalCount.Value} {animalCount.Key}");
             }

            // this._animals.ForEach(a => output.Append($"   {a}\n"));
            // output.Append($"Grazing field {shortId} ({animalSummary.ToString()})\n");
            output.Append($"Duck house {shortId} ({String.Join(", ", animalSummary)})\n");

            return output.ToString();
        }
    }
}