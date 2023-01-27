using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTask
{
    public class GalleryClass : ICarService
    {
        public int Id { get; set; }
        public string GalleryName { get; set; }
        public Car[] cars;
        public GalleryClass(int id,string galleryName)
        {
            Id=id;
            GalleryName=galleryName;
            cars = new Car[0];
        }

        public void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;
        }

        public void ShowAllCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.CarId}-------{car.CarName}--------{car.CarCode}");
            }
        }

        public Car FindCarById(int id)
        {
            foreach (Car car in cars)
            {
                if (car.CarId == id)
                {
                    return car;
                }
            }
            return null;
        }

        public Car FindCarByCarCode(string code)
        {
            foreach (Car car in cars)
            {
                if (car.CarCode.ToLower() == code.ToLower())
                {
                    return car;
                }
            }
            return null;
        }

        public Car[] FindCarsBySpeedInterval(double minSpeed, double maxSpeed)
        {
            Car[] filteredCars = new Car[0];
            foreach (Car car in cars)
            {
                if (car.Speed >= minSpeed && car.Speed <= maxSpeed)
                {
                    Array.Resize(ref filteredCars, filteredCars.Length + 1);
                    filteredCars[filteredCars.Length - 1] = car;
                }
            }
            return filteredCars;
        }
    }
}
