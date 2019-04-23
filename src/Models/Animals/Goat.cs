using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Goat : IResource, IGrazing, ICompostProducing {

        private Guid _id = Guid.NewGuid();
        public double GrassPerDay { get; set; } = 5.4;
        private double _compostProduced = 7.5;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Goat";

        // Methods
        public double CollectCompost()
        {
            return _compostProduced;
        }

        public void Graze () {
            Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public override string ToString () {
            return $"Goat {this._shortId}. Maaa!";
        }
    }
}