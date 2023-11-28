using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.domain.model
{
    public class Parking
    {
        private  double _price; 
        private double _pricePerHour;

        private string? _vehicles; 

        public Parking() {}

        public Parking(double price, double pricePerHour, string vehicles) {
            this._price = price;
            this._pricePerHour = pricePerHour;
            this._vehicles = vehicles;
            
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

        public void SetVehicle(string placeCar) {
            this._vehicles = placeCar;
        }

        public string GetVehicle() {
            return this._vehicles;
        }

    }
}