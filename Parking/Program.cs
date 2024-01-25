using Parking.domain.model;
using Parking.domain.service.serviceImpl;

namespace projeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            ParkingServiceImpl service = new();
            ParkingDIO parking = new();

            Console.WriteLine("---------Wellcome to Parking!----------");
            Console.WriteLine("[1] - Add Plate");
            Console.WriteLine("[2] - Remove Plate");
            Console.WriteLine("[3] - List Plates");
            Console.WriteLine("[4] - Exit");
           
            int option = 0;
            
            while (option != 4)
            {        
                #pragma warning disable CS8604 // Possible null reference argument.      
                option = int.Parse(Console.ReadLine()); 
                switch (option)
                {
                    case 1:
                    {
                        Console.WriteLine("What the fixed price?");
                        var fixedPrice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Plate car");
                        var plateCar = Console.ReadLine();
                        parking.SetPrice(fixedPrice);
                        parking.SetPlateCar(plateCar);
                        service.addVehicle(parking);
                        break;           
                               
                    }

                    case 2:
                    {
                        Console.WriteLine("Plate car");
                        var plateCar = Console.ReadLine().ToUpper();
                        Console.WriteLine("Price per hour");
                        var pricePerHour = int.Parse(Console.ReadLine());

                        service.removeVehicle(plateCar,pricePerHour);
                        break;
                    }

                    case 3:
                    {
                        service.listVehicle();
                        break;
                    }

                    case 4:
                    {
                        Console.WriteLine("Bye!");
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("[1] - Add Plate");
                        Console.WriteLine("[2] - Remove Plate");
                        Console.WriteLine("[3] - List Plates");
                        Console.WriteLine("[4] - Exit");
                        break;
                    }
                }

            Console.WriteLine("[1] - Add Plate");
            Console.WriteLine("[2] - Remove Plate");
            Console.WriteLine("[3] - List Plates");
            Console.WriteLine("[4] - Exit");    
            }
        }   
    }    
}
        
    
