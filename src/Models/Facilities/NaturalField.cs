using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<INatural>
    {
        private int _capacity = 10;
        private Guid _id = Guid.NewGuid();

        private List<INatural> _plants = new List<INatural>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (Farm farm, INatural plant)
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

            output.Append($"Natural field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }
    }
}