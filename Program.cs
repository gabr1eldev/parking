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

            Console.WriteLine("---------Wellcome to Parking!---------- \n");
           

            #pragma warning disable CS8604 // Possible null reference argument.
            int option = int.Parse(Console.ReadLine());
            
            while (option != 4)
            {
                Console.WriteLine("[1] - Add Plate");
                Console.WriteLine("[2] - Remove Plate");
                Console.WriteLine("[3] - List Plates");
                Console.WriteLine("[4] - Exit");
                switch (option)
                {
                    case 1:
                    {

                        Console.WriteLine("Fixed Price");
                        #pragma warning disable CS8604 // Possible null reference argument.
                        var fixedPrice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Plate car");
                        var plateCar = Console.ReadLine();
                        parking.SetPrice(fixedPrice);
                        #pragma warning disable CS8604 // Possible null reference argument.
                        parking.SetPlateCar(plateCar);
                        service.addVehicle(parking);
                        break;
                        
                    }
                }
            }

        }   
    }    
}
        
    
