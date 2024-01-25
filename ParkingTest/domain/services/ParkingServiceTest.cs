
using Parking.domain.model;
using Parking.domain.repository;
using Parking.domain.service.serviceImpl;

namespace ParkingTest.domain.services
{

    public class ParkingServiceTest
    {
        ParkingRepository _repository;
        ParkingServiceImpl _service;

        public ParkingServiceTest() 
        {
            _repository = new ParkingRepository();
            _service = new ParkingServiceImpl();
        }

        [Theory(DisplayName = "Should save a car class")]
        [InlineData(5,10,"xxx-1010")]
        [InlineData(20, 30, "xjk-1019")]
        [InlineData(30, 25, "kjh-1920")]
        [InlineData(15, 25, "lmj-2981")]
        public void saveCar(double price,double pricePerHour,string plateCar)
        {
            ParkingDIO parking = new ParkingDIO(price, plateCar);
            parking.SetPricePerHour(pricePerHour);
            _service.addVehicle(parking);

            foreach (var result in _repository.GetVehicles())
            {
                Assert.Equal(parking,result);
            }          
        }


        [Theory(DisplayName = "Should remove a car class")]
        [InlineData(5, 10, "xxx-1010")]
        [InlineData(20, 30, "xjk-1019")]
        [InlineData(30, 25, "kjh-1920")]
        [InlineData(15, 25, "lmj-2981")]
        public void removeCar(double price, double pricePerHour, string plateCar)
        {
            ParkingDIO parking = new ParkingDIO(price, plateCar);
            parking.SetPricePerHour(pricePerHour);
            _service.removeVehicle(plateCar,pricePerHour);

            foreach (var result in _repository.GetVehicles())
            {
                Assert.Empty((System.Collections.IEnumerable)result);
            }
        }

    }
}