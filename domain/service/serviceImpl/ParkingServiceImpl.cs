using System.Data;
using projeto.domain.model;
using projeto.domain.repository;

namespace projeto.domain.service.serviceImpl
{
    public class ParkingServiceImpl : ParkingService
    {
        
        ParkingRepository repository = new();
        
        public string addVehicle(Parking parking)
        {
            repository?.AddVehicle(parking);
            return $"Car with plate {parking.GetPlateCar()} add success!";
        }

        public List<Parking>? listVehicle()
        {
            return (List<Parking>?)(repository?.GetVehicles()?.Select(item => item));
            
        }

        public string removeVehicle(string plateCar, double pricePerHour)
        {
            Parking parking = new();
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