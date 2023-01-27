using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTask
{
    public interface ICarService
    {
        void AddCar(Car car);
        void ShowAllCars();
        
        Car FindCarById(string id);
        Car FindCarByCarCode(string code);
        //Car[] FindCarsBySpeedInterval(double minSpeed, double maxSpeed);

    }
}
