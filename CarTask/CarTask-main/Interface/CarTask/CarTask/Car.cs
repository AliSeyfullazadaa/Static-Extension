using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTask
{
    public  class Car
    {
        public string CarId { get; set; }
        public string CarName { get; set; }
        public double Speed { get; set; }
        private string _carCode;
        private int _count=1;
        public string CarCode;
        public Car(string id, string name,double speed)
        {
            CarId= id;
            CarName= name;
            Speed= speed;
            CarCode = Extensions.CapitalizeFirstTwoLetter(CarName, _count);

           
        }

    }
}
