using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.domain.model
{
    public class Vehicles
    {
        private List<Object>? _vehicles;

        public Vehicles() {}

        public Vehicles(List<Object> vehicles) {
            this._vehicles = vehicles;
        }


        public List<Object>? GetVehicles() {
            return _vehicles;
        }

        public void AddVehicle(Object vehicle) {
           this._vehicles?.Add(vehicle);
           
        }

        public void removeVehicle(string plateCar) {
            this._vehicles?.Remove(plateCar);
        }
    } 
}