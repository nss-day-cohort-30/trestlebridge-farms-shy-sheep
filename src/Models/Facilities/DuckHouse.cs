using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities {
    public class DuckHouse : IFacility<Duck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<Duck> _animals = new List<Duck>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (Farm farm, Duck animal)
        {
            if (_animals.Count < _capacity) {
                _animals.Add(animal);
                ChooseDuckHouse.UserTriedToSelectAFullFacility = false;
            }
            else
            {
                ChooseDuckHouse.UserTriedToSelectAFullFacility = true;
                ChooseDuckHouse.CollectInput(farm, animal);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._animals.Count} of {this._capacity} ducks.\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}