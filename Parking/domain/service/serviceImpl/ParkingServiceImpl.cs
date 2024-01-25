using Parking.domain.repository;
using Parking.domain.model;
using Parking.domain.exceptions;

namespace Parking.domain.service.serviceImpl
{
    public class ParkingServiceImpl : ParkingService
    {
        
        private ParkingRepository repository;

        public ParkingServiceImpl()
        {
            this.repository = new ParkingRepository();
        }

        public void addVehicle(ParkingDIO parking)
        {
    
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (parking.GetPrice() <= 0) 
            {
                throw new DomainException("The price cant be zero or negative.");
                
            } 
            else if (parking.GetPlateCar() == null 
                || parking.GetPlateCar().Equals(typeof(int))
                || parking.GetPlateCar().Equals(typeof(double)))
            {
                throw new DomainException("The plate car is incorrect!");
            } 
            else 
            {
                repository?.AddVehicle(parking);
                Console.WriteLine("Add success!");
            }         
        }

        public void listVehicle()
        {
            #pragma warning disable CS8604 // Possible null reference argument.
            foreach (var vehicle in repository.GetVehicles().ToList())
            {
                if (vehicle == null)
                {
                    throw new DomainException("There is not vehicle in parking");
                } else
                {
                    Console.WriteLine(vehicle);
                }
                
            }
            //return repository.GetVehicles().Select(vehicle => vehicle).ToList();
        }
      
        public void removeVehicle(string plateCar, double pricePerHour)
        {
            if(pricePerHour <= 0)
            { 
                throw new DomainException("Wrong price per hour.");
            } else
            {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                foreach (var vehicle in repository.GetVehicles())
                {                   
                    double total = vehicle.GetPrice() * pricePerHour;
                    repository?.RemoveVehicle(vehicle);
                    Console.WriteLine($"Total price is {total}");
                }         
            }
        } 
    }
}