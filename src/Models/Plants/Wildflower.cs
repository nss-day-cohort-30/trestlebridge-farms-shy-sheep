using System;
using Trestlebridge.Interfaces;
using System.Collections.Generic;
namespace Trestlebridge.Models.Plants
{
    public class Wildflower 
    //: ICompost, INatural, IResource
    {
        private double _CompostProduced = 30.3;
        public string Type { get; } = "Wildflower";

        public double Harvest () {
            return _CompostProduced;
        }

        public override string ToString () {
            return $"Wildflower. Yum!";
        }
    }
}