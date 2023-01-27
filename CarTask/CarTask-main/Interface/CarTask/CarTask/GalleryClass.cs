using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTask
{
    public class GalleryClass
    {
        public int Id { get; set; }
        public string GalleryName { get; set; }
        public int Limit { get; set; }
        public Car[] cars;
        public GalleryClass(int id,string galleryName,int limit)
        {
                Id=id;
            GalleryName=galleryName;
            Limit=limit;
            cars = new Car[0];
        }
        public bool AddCar(Car car)
        {
            if (cars.Length<Limit)
            {
                Array.Resize(ref cars, cars.Length + 1);
                cars[cars.Length - 1] = car;
                return true;
            }
            else
            {
                Console.WriteLine("Gallery is full");
            }
            return false;
        }
        
    }
}
