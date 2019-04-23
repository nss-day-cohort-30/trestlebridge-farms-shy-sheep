using System;
using Trestlebridge.Interfaces;
using System.Collections.Generic;
namespace Trestlebridge.Models.Plants
{
    public class Wildflower : ICompostProducing, IResource
    {
        private double _compostProduced = 30.3;
        public string Type { get; } = "Wildflower";

        public double CollectCompost()
        {
            return _compostProduced;
        }

        public override string ToString () {
            return $"Wildflower. Pretty!";
        }
    }
}