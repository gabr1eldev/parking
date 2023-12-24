using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto.domain.model;

namespace projeto.domain.repository
{
    public class ParkingRepository 
    {
        private readonly List<ParkingDIO>? _vehicles = new();

        public ParkingRepository() {}

        public ParkingRepository(List<ParkingDIO> vehicles) {
            this._vehicles = vehicles;
        }


        public List<ParkingDIO>? GetVehicles() {       
            
            return this?._vehicles ?? null;        
        }

        public void AddVehicle(ParkingDIO vehicle) {
           this._vehicles?.Add(vehicle);
           
        }

        public string removeVehicle(ParkingDIO parking) {
            this._vehicles?.Remove(parking);
            return "Success remove";
        }
    } 
}