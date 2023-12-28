using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parking.domain.model;

namespace Parking.domain.service
{
    public interface ParkingService
    {
        public void addVehicle(ParkingDIO parking);
        public void removeVehicle(string plateCar, double pricePerHour);
        public void listVehicle();
    }
}