using System.Collections.Generic;

namespace Trestlebridge.Interfaces
{
    public interface IProcessingEquipment<T>
    {
        double Capacity { get; }


        void ProcessResource(List <T> resource); 

    }
}