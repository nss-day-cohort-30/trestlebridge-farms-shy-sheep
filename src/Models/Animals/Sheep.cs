using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Sheep : IResource, IMeatProducing, IGrazing {

        private Guid _id = Guid.NewGuid();

        private double _meatProduced = 5;

        public double GrassPerDay { get; set; } = 2.1;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Sheep";

        // Methods
        public void Graze () {
            Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }
         public double Butcher () {
            return _meatProduced;
        }

        public override string ToString () {
            return $"Sheep {this._shortId}. Baaaa!";
        }
    }
}