using projeto.domain.model;
using projeto.domain.service.serviceImpl;


namespace projeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            ParkingServiceImpl service = new();
            Parking parking = new();

            Console.WriteLine("---------Wellcome to Parking!----------");
            Console.WriteLine("[1] - Add Plate");
            Console.WriteLine("[2] - Remove Plate");
            Console.WriteLine("[3] - List Plates");
            Console.WriteLine("[4] - Exit");
           

            #pragma warning disable CS8604 // Possible null reference argument.
            int option = int.Parse(Console.ReadLine());
            
            while (option != 4)
            {               
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
                        var result = service.addVehicle(parking);
                        Console.WriteLine(result);
                        break;
                        
                    }

                    case 2:
                    {
                        Console.WriteLine("Plate car");
                        var plateCar = Console.ReadLine();
                        Console.WriteLine("Price per hour");
                        var pricePerHour = int.Parse(Console.ReadLine());

                        var result = service.removeVehicle(plateCar,pricePerHour);
                        Console.WriteLine(result);
                        break;
                    }

                    case 3:
                    {
                        var listVehicle = service.listVehicle();
                        Console.WriteLine(listVehicle);
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
        
    
