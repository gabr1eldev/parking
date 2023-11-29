using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto.domain.model;

namespace projeto.domain.service
{
    public interface ParkingService
    {
        public string addVehicle(double price, string plateCar);
        public string removeVehicle(string plateCar, double pricePerHour);
        public List<Parking>? listVehicle();
    }
}