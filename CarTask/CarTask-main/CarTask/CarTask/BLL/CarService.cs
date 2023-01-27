using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTask
{
    public class CarService
    {
        private ICarService _carService;
        public CarService(ICarService carService)
        {
            _carService = carService;
        }
        public void Add(Car car)
        {
            if (car != null)
            {
                _carService.AddCar(car);
            }
        }
        public void ShowAllCars()
        {
            _carService.ShowAllCars();
        }
        public Car FindCarById(int id)
        {
            if (id != null)
            {
                return _carService.FindCarById(id);
            }
            return null;
        }
        public Car FindCarByCarCode(string code)
        {
            if (!string.IsNullOrWhiteSpace(code))
            {
                return _carService.FindCarByCarCode(code);
            }
            return null;
        }

        public Car[] FindCarsBySpeedInterval(double minSpeed, double maxSpeed)
        {
            return _carService.FindCarsBySpeedInterval(minSpeed, maxSpeed);
        }

    }




}
