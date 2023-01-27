using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTask
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public double Speed { get; set; }
        private string _carCode;
        private static int _count = 1;
        public string CarCode { get { return _carCode; } set { _carCode = value; } }
        public Car(int id, string name, double speed)
        {
            CarId = id;
            CarName = name;
            Speed = speed;
            CarCode = Extensions.CapitalizeFirstTwoLetter(CarName, _count);
            _count++;
        }

    }
}
