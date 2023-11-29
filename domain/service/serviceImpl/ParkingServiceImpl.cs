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
            return $"Car with plate {parking.GetPlateCar()} add success!";
        }

        public List<Parking>? listVehicle()
        {
            foreach (var item in repository.GetVehicles())
            {
                return item;
            }
        }

        public string removeVehicle(string plateCar, double pricePerHour)
        {
            Parking parking = new Parking();
            if(parking.GetPlateCar() == plateCar) {
                double total = parking.GetPrice() * pricePerHour;
                repository?.removeVehicle(parking);
                return $"Total price is {total}";
            } else {
                return "Plate incorrect";
            }
        }

  
    }
}