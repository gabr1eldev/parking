using System.Data;
using projeto.domain.model;
using projeto.domain.repository;

namespace projeto.domain.service.serviceImpl
{   
    public class ParkingServiceImpl : ParkingService
    {
        private ParkingRepository repository = new();
        
        public string addVehicle(Parking parking)
        {
            repository?.AddVehicle(parking);
            return $"Car with plate {parking.GetPlateCar()} add success!";
        }

        public List<Parking>? listVehicle()
        {
            #pragma warning disable CS8604 // Possible null reference argument.
            return (repository?.GetVehicles()?.Select(item => item)).ToList();

        }
      
        public string removeVehicle(string plateCar, double pricePerHour)
        {
            return repository.GetVehicles().Select(vehicle => {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                if (vehicle.GetPlateCar().Contains(plateCar))
                    {                     
                        double total = vehicle.GetPrice() * pricePerHour;
                        repository?.removeVehicle(vehicle);
                        return $"Total price is {total}";
                } else {
                    return "Plate incorrect";
                }
            }).ToString();
        } 

        private static Parking GetParking()
        {
            Parking parking = new();
            return parking;
        }
    }
}