
using Parking.domain.model;
using Parking.domain.repository;
using Parking.domain.service.serviceImpl;

namespace ParkingTest.domain.services
{

    public class ParkingServiceTest
    {
        ParkingRepository _repository;
        ParkingServiceImpl _service;
        ParkingDIO _parking;

        public ParkingServiceTest() 
        {
            _repository = new ParkingRepository();
            _service = new ParkingServiceImpl();
            _parking = new ParkingDIO();
        }

        [Theory(DisplayName = "Should save a car class")]
        [InlineData(5,10,"xxx-1010")]
        [InlineData(20, 30, "xjk-1019")]
        [InlineData(30, 25, "kjh-1920")]
        [InlineData(15, 25, "lmj-2981")]
        public void SaveCar(double price,double pricePerHour,string plateCar)
        {
            _parking.SetPrice(price);
            _parking.SetPricePerHour(pricePerHour);
            _parking.SetPlateCar(plateCar);
            _service.addVehicle(_parking);

            foreach (var result in _repository.GetVehicles())
            {
                Assert.Equal(_parking,result);
            }          
        }

        

        [Theory(DisplayName = "Should remove a car class")]
        [InlineData(5, 10, "xxx-1010")]
        [InlineData(20, 30, "xjk-1019")]
        [InlineData(30, 25, "kjh-1920")]
        [InlineData(15, 25, "lmj-2981")]
        public void RemoveCar(double price, double pricePerHour, string plateCar)
        {
            
            _parking.SetPrice(price);
            _parking.SetPricePerHour(pricePerHour);
            _parking.SetPlateCar(plateCar);

            _service.removeVehicle(plateCar, pricePerHour);

            foreach (var result in _repository.GetVehicles())
            {
                Assert.Empty((System.Collections.IEnumerable)result);
            }
        }


       

    }
}