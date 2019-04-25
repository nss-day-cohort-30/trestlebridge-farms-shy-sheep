using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<ISeedProducing>
    {
        private int _capacity = 13;
        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _plants = new List<ISeedProducing>();

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
                return _plants.Count;
            }
        }

        public void AddResource(Farm farm, string seedChoice, int amountChoice)
        {
            int emptySpace = _capacity - _plants.Count;
            if (emptySpace >= amountChoice)
            {

                if (seedChoice == "Sesame")
                {
                    for (int i = 0; i < amountChoice; i++)
                    {
                        _plants.Add(new Sesame());
                    }
                }

                else if (seedChoice == "Sunflower")
                {

                    for (int i = 0; i < amountChoice; i++)
                    {
                        _plants.Add(new Sunflower());
                    }
                }

            }
            else
            {
                ChoosePlowedField.UserTriedToSelectAFullFacility = true;
                ChoosePlowedField.CollectInput(farm, seedChoice, amountChoice);
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