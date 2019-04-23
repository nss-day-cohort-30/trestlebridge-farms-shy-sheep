using System.Collections.Generic;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
    public interface IFacility<T>
    {
        double Capacity { get; }

        void AddResource (Farm farm, T resource);
        // void AddResource (List<T> resources);
    }
}