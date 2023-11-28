using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto.domain.model;
using projeto.domain.repository;

namespace projeto.domain.service.serviceImpl
{
    public class ParkingServiceImpl : ParkingService
    {

        private ParkingRepository? repository;

        public string addVehicle(double price, string placeCar)
        {
            Parking parking = new Parking(price , placeCar);
            repository?.AddVehicle(parking);
            return $"Car {parking.GetVehicle()} add success!";
        }

        public List<Parking>? listVehicle()
        {
            return repository?.GetVehicles();
        }

        public string removeVehicle()
        {
            throw new NotImplementedException();
        }
    }
}