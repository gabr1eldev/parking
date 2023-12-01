using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto.domain.model;

namespace projeto.domain.service
{
    public interface ParkingService
    {
        public string addVehicle(Parking parking);
        public void removeVehicle(string plateCar, double pricePerHour);
        public void listVehicle();
    }
}