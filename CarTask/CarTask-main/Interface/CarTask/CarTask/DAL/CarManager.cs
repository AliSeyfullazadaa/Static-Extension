using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTask
{
    public class CarManager : ICarService
    {
        GalleryClass gallery; 

        Car[] cars = new Car[3];
        private readonly Car _car;
        public CarManager(Car car)
        {
            _car = car;
        }
       
        public void AddCar(Car car)
        {
            if (cars.Length<gallery.Limit)
            {

                Array.Resize(ref cars, cars.Length+1);
                cars[cars.Length-1] = car;
                

            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public Car FindCarByCarCode(string code)
        {

            foreach (Car car in cars)
            {
                if (code == _car.CarCode)
                {
                    return _car;


                }
                else
                {
                    _car.CarCode = "Unknown";
                }

            }
            return _car;


        }

        public Car FindCarById(string id)
        {
            foreach ( Car car in cars)
            {
                if (id==_car.CarId)
                {
                    return _car;
                }
                else
                {
                    _car.CarId = null;
                }
            }
            return _car;

        }

        //public Car[] FindCarsBySpeedInterval(double minSpeed, double maxSpeed)
        //{

        //}


        public void ShowAllCars()
        {
            foreach (Car car in cars)
            {
               Console.WriteLine($"{_car.CarCode}-------{_car.CarName}--------{_car.CarCode}");
            }
        }
    }
}
