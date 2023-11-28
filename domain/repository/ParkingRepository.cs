using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.domain.repository
{
    public class ParkingRepository
    {
        private List<Object>? _vehicles;

        public ParkingRepository() {}

        public ParkingRepository(List<Object> vehicles) {
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