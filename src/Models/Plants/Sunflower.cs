using System;
using Trestlebridge.Interfaces;
namespace src.Models.Plants
{
    public class Sunflower //: INatural, IPlow, ISeed
    {
        private double _CompostProduced = 21.6;
        public string Type { get; } = "Sunflower";

        public double Harvest () {
            return _CompostProduced;
        }

        public override string ToString () {
            return $"Sunflower. Yum!";
        }
    }
}