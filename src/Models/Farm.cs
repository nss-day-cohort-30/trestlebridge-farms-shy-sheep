using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Facilities
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();
        

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
           Farm farm = this;
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource(farm, (IGrazing)resource);
                    break;
                case "Ostrich":
                    GrazingFields[index].AddResource(farm, (IGrazing)resource);
                    break;
                case "Chicken":
                    ChickenHouses[index].AddResource(farm, (Chicken)resource);
                    break;
                case "Duck":
                    DuckHouses[index].AddResource(farm, (Duck)resource);
                    break;
                case "Goat":
                    GrazingFields[index].AddResource(farm, (IGrazing)resource);
                    break;
                case "Pigs":
                    GrazingFields[index].AddResource(farm, (IGrazing)resource);
                    break;
                case "Sheep":
                    GrazingFields[index].AddResource(farm, (IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

        // internal object GetChickenFeeds()
        // {
        //     throw new NotImplementedException();
        // }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public void AddNaturalField (NaturalField field)
        {
            NaturalFields.Add(field);
        }

        public void AddPlowedField (PlowedField field) {

            PlowedFields.Add(field);
        }

        public void AddDuckHouse(DuckHouse house) {

            DuckHouses.Add(house);
        }


        public void AddChickenHouse(ChickenHouse house) {

            ChickenHouses.Add(house);
        }


        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            NaturalFields.ForEach(nf => report.Append(nf));
            PlowedFields.ForEach(pf => report.Append(pf));
            ChickenHouses.ForEach(ch => report.Append(ch));
            DuckHouses.ForEach(dh => report.Append(dh));

            return report.ToString();
        }
    }


}