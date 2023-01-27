using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTask
{
    public class CarService{

        private ICarService _carService;
        public CarService(ICarService carService)
        {
            _carService= carService;
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
        public Car FindCarById(string id)
        {

            return _carService.FindCarById(id);
        }
        //public Car FindCarByCarCode()
        //{
        //    return _carService.FindCarByCarCode();
        //}
    }
       
    

    
}
