using CarTask;

Console.WriteLine("CAR SYSTEM\n");
GalleryClass[] galleries = new GalleryClass[0];
AddGallery();
CarManager carManager = new CarManager(AddCar());
CarService carService = new CarService(carManager);
carService.Add(AddCar());
carService.ShowAllCars();





void AddGallery()
{
    Console.Write("Group Id:");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Limit: ");
    int limit= Convert.ToInt32(Console.ReadLine());
    Console.Write("Name: ");
    string name=Console.ReadLine();
    GalleryClass gallery = new GalleryClass(id, name, limit);
    Array.Resize(ref galleries, galleries.Length+1);
    galleries[galleries.Length-1] = gallery;
}
 Car AddCar()
{
    Console.Write ("Car Id: ");
    string id=Console.ReadLine();
    Console.Write("Car Name: ");
    string name=Console.ReadLine();
    Console.Write("Car Speed: ");
    double speed = Convert.ToDouble(Console.ReadLine());
    Car car = new Car(id, name,speed);
    return car;

}

