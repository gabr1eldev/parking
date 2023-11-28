using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.model
{
    public class Parking
    {
        private  double _price; 
        private double _pricePerHour;

        public Parking() {}

        public Parking(double price, double pricePerHour) {
            this._price = price;
            this._pricePerHour = pricePerHour;
            
        }

        public void SetPrice(double price) {
            this._price = price;
        }

        public double GetPrice() {
            return this._price;
        }

        public void SetPricePerHour(double pricePerHour) {
            this._pricePerHour = pricePerHour;
        }

        public double GetPricePerHour() {
            return this._pricePerHour;
        }

    }
}