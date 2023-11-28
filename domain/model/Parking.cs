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

        private string? _plateCar; 

        public Parking() {}

        public Parking(double price, string plateCar) {
            this._price = price;
            this._plateCar = plateCar;
            
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

        public void SetPlateCar(string placeCar) {
            this._plateCar = placeCar;
        }

        public string? GetPlateCar() {
            return this._plateCar;
        }

        internal object GetVehicle()
        {
            throw new NotImplementedException();
        }
    }
}