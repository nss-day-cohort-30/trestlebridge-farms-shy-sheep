using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class SeedHarvester //: IProcessingEquipment<ISeedProducing>
    {
        private double _capacity = 5;
        public double Capacity
        {
            get { return _capacity; }
        }

        public void ProcessResource(List<ISeedProducing> resources)
        {
            resources.ForEach(plant => {
                plant.Harvest();
                resources.Remove(plant);
            });
        }
    }
}