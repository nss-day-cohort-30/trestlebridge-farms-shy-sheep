using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<ICompostProducing>
    {
        private int _capacity = 10;
        private Guid _id = Guid.NewGuid();

        private List<ICompostProducing> _plants = new List<ICompostProducing>();

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

        public void AddResource(Farm farm, List<ICompostProducing> plants)
        {
            _plants.AddRange(plants);
        }
        public void AddResource(Farm farm, ICompostProducing plant)
        {
            //refactor IFacility into two separate interfaces for animal facilities and plant facilities so we can get rid of this
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            List<string> plantSummary = new List<string>();
            Dictionary<string, int> totalPlantCounts = new Dictionary<string, int>();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            _plants.ForEach(plant => {
                //Type property is inaccessible on plant because it is currently Type ICompostProducing
                //Cast (change from one type to another) to Type IResource so it becomes available
                IResource castPlant = (IResource)plant;
                if (!totalPlantCounts.ContainsKey(castPlant.Type))
                {
                    totalPlantCounts[castPlant.Type] = 1;
                }
                else
                {
                    totalPlantCounts[castPlant.Type] += 1;
                }
            });

             foreach (KeyValuePair<string, int> plantCount in totalPlantCounts)
             {
                 plantSummary.Add($"{plantCount.Value} {plantCount.Key}");
             }

            output.Append($"Natural field {shortId} ({String.Join(", ", plantSummary)})\n");

            return output.ToString();
        }
    }
}