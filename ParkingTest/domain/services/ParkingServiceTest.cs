
using Parking.domain.exceptions;
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
        [InlineData(5,10,"xxx-1010")]
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


        [Theory(DisplayName = "Should impossible save a car with price < 1")]
        [InlineData(0, 10, "xxx-1010")]
        [InlineData(-1, 15, "xjk-1019")]
        [InlineData(-20, 20, "kjh-1920")]
        [InlineData(-50, -5, "lmj-2981")]
        public void CantSavePriceIncorrect(double price,double pricePerHour, string plateCar)
        {
            _parking.SetPrice(price);
            _parking.SetPricePerHour(pricePerHour);
            _parking.SetPlateCar(plateCar);

            var message = Assert.Throws<DomainException>(() => _service.addVehicle(_parking)).Message;

            Assert.Equal("The price cant be zero or negative.", message);
        }


        [Theory(DisplayName = "should impossible save a car with price < 1")]
        [InlineData(10, -1, "xxx-1010")]
        [InlineData(15, 0, "xjk-1019")]
        [InlineData(1, -15, "kjh-1920")]
        [InlineData(12, -5, "lmj-2981")]
        public void CantRemovePriceIncorrect(double price, double pricePerHour, string plateCar)
        {
            _parking.SetPrice(price);
            _parking.SetPricePerHour(pricePerHour);
            _parking.SetPlateCar(plateCar);

            var message = Assert.Throws<DomainException>(() => _service.removeVehicle(plateCar,pricePerHour)).Message;

            Assert.Equal("Wrong price per hour.", message);
        }


        [Theory(DisplayName = "Should be impossible to remove a car with wrong plate")]
        [InlineData(5, 10, "KKK-1010")]
        public void CantRemoveCarWrongPlate(double price, double pricePerHour, string plateCar)
        {

            ParkingDIO remove = new ParkingDIO(price,pricePerHour,"XXXX");
            _service.addVehicle(remove);


            var message = Assert.Throws<DomainException>(() => _service.removeVehicle(plateCar, pricePerHour)).Message;
            Assert.Equal("Wrong plate or the car its not exist.", message);

        }
    }
}