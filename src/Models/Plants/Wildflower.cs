using System;
using Trestlebridge.Interfaces;
namespace src.Models.Plants
{
    public class Wildflower : IResource, ISeedProducing
    {
        private int _seedsProduced = 911;
        public string Type { get; } = "Wildflower";

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Wildflower. Yum!";
        }
    }
}