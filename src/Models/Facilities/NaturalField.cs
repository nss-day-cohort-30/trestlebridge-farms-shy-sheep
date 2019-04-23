using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;

namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<ICompostProducing>
    {
        private int _capacity = 10;
        private Guid _id = Guid.NewGuid();

        private List<ICompostProducing> _plants = new List<ICompostProducing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public double CurrentCapacity {
            get {
                return _plants.Count;
            }
        }

        public void AddResource (Farm farm, ICompostProducing plant)
        {
            if (_plants.Count < _capacity) {
                _plants.Add(plant);
                ChooseNaturalField.UserTriedToSelectAFullFacility = true;
            }
            else
            {
                ChooseNaturalField.UserTriedToSelectAFullFacility = false;
                ChooseNaturalField.CollectInput(farm, plant);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._plants.Count} of {this._capacity} rows of plants.\n");
            this._plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }
    }
}