using System;
using Trestlebridge.Interfaces;
namespace src.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing
    {
        private int _seedsProduced = 650;
        public string Type { get; } = "Sunflower";

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sunflower. Yum!";
        }
    }
}