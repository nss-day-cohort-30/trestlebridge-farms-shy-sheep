using System;
using Trestlebridge.Interfaces;
namespace src.Models.Plants
{
    public class Wildflower : ICompost, INatural, IResource
    {
        public string Type { get; } = "Wildflower";

        public double Harvest () {
            return _CompostProduced;
        }

        public override string ToString () {
            return $"Wildflower. Yum!";
        }
    }
}