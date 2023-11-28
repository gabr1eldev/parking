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

        public string addVehicle(double price, double pricePerHour, string placeCar)
        {
            
        }

        public List<Parking> listVehicle()
        {
            throw new NotImplementedException();
        }

        public string removeVehicle()
        {
            throw new NotImplementedException();
        }
    }
}