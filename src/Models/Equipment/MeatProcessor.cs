using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class MeatProcessor : IProcessingEquipment<IMeatProducing>
    {
        private int _capacity = 7;
        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void ProcessResource(IMeatProducing equipment, IMeatProducing facility, IMeatProducing plantOrAnimal, int quantity)
        {
            facility.RemoveResource
        }
    }
}