using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;

namespace Trestlebridge.Models.Facilities {
    public class PlowedField : IFacility<ISeedProducing>
    {
        private int _capacity = 13;
        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _plants = new List<ISeedProducing>();

        public double MaxCapacity {
            get {
                return _capacity;
            }
        }

        public double CurrentCapacity {
            get {
                return _plants.Count;
            }
        }

        public void AddResource (Farm farm, ISeedProducing plant)
        {
            if (_plants.Count < _capacity) {
                _plants.Add(plant);
                ChoosePlowedField.UserTriedToSelectAFullFacility = true;
            }
            else
            {
                ChoosePlowedField.UserTriedToSelectAFullFacility = false;
                ChoosePlowedField.CollectInput(farm, plant);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._plants.Count} of {this._capacity} rows of plants.\n");
            this._plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }
    }
}