using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Pig : IResource, IMeatProducing, IGrazing {

        private Guid _id = Guid.NewGuid();

        private double _meatProduced = 8.4;
        public double GrassPerDay { get; set; } = 6.4;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Pig";

        // Methods
         public void Graze () {
            Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }


         public double Butcher () {
            return _meatProduced;
            
        }

        public override string ToString () {
            return $"Pig {this._shortId}. Oink!";
        }
    }
}