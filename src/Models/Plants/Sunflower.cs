using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ICompostProducing, ISeedProducing
    {
        private double _compostProduced = 21.6;
        private int _seedsProduced = 650;
        public string Type { get; } = "Sunflower";

        public double CollectCompost () {
            return _compostProduced;
        }

        public double Harvest()
        {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sunflower. Yum!";
        }
    }
}