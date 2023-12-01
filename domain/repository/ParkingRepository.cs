using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto.domain.model;

namespace projeto.domain.repository
{
    public class ParkingRepository 
    {
        private readonly List<Parking>? _vehicles = new();

        public ParkingRepository() {}

        public ParkingRepository(List<Parking> vehicles) {
            this._vehicles = vehicles;
        }


        public List<Parking>? GetVehicles() {       
            
            return this?._vehicles ?? null;        
        }

        public void AddVehicle(Parking vehicle) {
           this._vehicles?.Add(vehicle);
           
        }

        public string removeVehicle(Parking parking) {
            this._vehicles?.Remove(parking);
            return "Success remove";
        }
    } 
}