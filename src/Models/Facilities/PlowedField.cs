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

        public void AddResource(Farm farm, List<ISeedProducing> plants) {
            _plants.AddRange(plants);
        }
        public void AddResource(Farm farm, ISeedProducing plant) {
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

            output.Append($"Plowed field {shortId} ({String.Join(", ", plantSummary)})\n");

            return output.ToString();
        }
    }
}