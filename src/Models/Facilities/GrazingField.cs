using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;

namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (Farm farm, IGrazing animal)
        {
            if (_animals.Count < _capacity) {
                _animals.Add(animal);
                ChooseGrazingField.UserTriedToSelectAFullFacility = false;
            }
            else
            {
                ChooseGrazingField.UserTriedToSelectAFullFacility = true;
                ChooseGrazingField.CollectInput(farm, animal);
            }
        }

        public void AddResource(IGrazing resource)
        {
            throw new NotImplementedException();
        }

        // public void AddResource (List<IGrazing> animals)  // TODO: Take out this method for boilerplate
        // {
        //     if (_animals.Count + animals.Count <= _capacity) {
        //         _animals.AddRange(animals);
        //     }
        // }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}