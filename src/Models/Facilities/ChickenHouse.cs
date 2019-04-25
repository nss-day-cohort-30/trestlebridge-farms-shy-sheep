using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities {
    public class ChickenHouse : IFacility<Chicken>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<Chicken> _animals = new List<Chicken>();

        public double MaxCapacity {
            get {
                return _capacity;
            }
        }

        public double CurrentCapacity {
            get {
                return _animals.Count;
            }
        }
        public void AddResource (Farm farm, Chicken animal)
        {
            if (_animals.Count < _capacity) {
                _animals.Add(animal);
                ChooseChickenHouse.UserTriedToSelectAFullFacility = false;
            }
            else
            {
                ChooseChickenHouse.UserTriedToSelectAFullFacility = true;
                ChooseChickenHouse.CollectInput(farm, animal);
            }
        }

        public void AddResource(Farm farm, List<Chicken> animals) {
            
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken house {shortId} has {this._animals.Count} of {this._capacity} Chicken.\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}