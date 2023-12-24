using projeto.domain.repository;
using projeto.domain.model;

namespace projeto.domain.service.serviceImpl
{
    public class ParkingServiceImpl : ParkingService
    {
        
        ParkingRepository repository = new();

        public void addVehicle(ParkingDIO parking)
        {
    

            repository?.AddVehicle(parking);
             
        }

        public void listVehicle()
        {
            #pragma warning disable CS8604 // Possible null reference argument.
            foreach (var vehicle in repository.GetVehicles().ToList())
            {
                Console.WriteLine(vehicle);
            }
            //return repository.GetVehicles().Select(vehicle => vehicle).ToList();
        }
      
        public void removeVehicle(string plateCar, double pricePerHour)
        {

            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (var vehicle in repository.GetVehicles().ToList())
            {
                if(vehicle.GetPlateCar().Equals(plateCar))
                {
                    double total = vehicle.GetPrice() * pricePerHour;
                    repository?.removeVehicle(vehicle);
                    Console.WriteLine($"Total price is {total}");
                } else {
                    Console.WriteLine("Plate incorrect");
                }
            /*
            #pragma warning disable CS8603 // Possible null reference return.
            return repository.GetVehicles().Select(vehicle => {
                Console.WriteLine(string.Equals(vehicle.GetPlateCar(),plateCar));
                if (string.Equals(vehicle.GetPlateCar(),plateCar))
                    {                     
                        double total = vehicle.GetPrice() * pricePerHour;
                        repository?.removeVehicle(vehicle);
                        return $"Total price is {total}";
                } else {
                    return "Plate incorrect";
                }
            }).ToString();
            */
            }
        } 
    }
}