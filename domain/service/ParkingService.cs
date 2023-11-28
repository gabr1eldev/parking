using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto.domain.model;

namespace projeto.domain.service
{
    public interface ParkingService
    {
        public string addVehicle(double price, double pricePerHour,string plateCar);
        public string removeVehicle();
        public List<Parking> listVehicle();
    }
}