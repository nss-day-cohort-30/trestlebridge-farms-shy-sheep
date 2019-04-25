using System.Collections.Generic;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Interfaces
{
    public interface IFacility<T>
    {
        double MaxCapacity { get; }
        double CurrentCapacity { get; }

        void AddResource(Farm farm, T resource); 
    }
}