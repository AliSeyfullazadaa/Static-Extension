using CarTask;

Console.WriteLine("CAR SYSTEM\n");
Console.Write("Gallery Id:");
int id = Convert.ToInt32(Console.ReadLine());
Console.Write("Name: ");
string name = Console.ReadLine();
CarService service = new CarService(new GalleryClass(id, name));

service.Add(AddCar());
service.Add(AddCar());
service.Add(AddCar());
service.Add(AddCar());
service.Add(AddCar());
service.Add(AddCar());

Console.WriteLine("-------------------------");
Console.WriteLine("Search Car by ID");
Console.Write("Car Id : ");
int carId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{service.FindCarById(carId).CarId}-------{service.FindCarById(carId).CarName}--------{service.FindCarById(carId).CarCode}");
Console.WriteLine("-------------------------");
Console.WriteLine("Search Car by Code");
Console.Write("Car Code : ");
string code = Console.ReadLine();
Console.WriteLine($"{service.FindCarByCarCode(code).CarId}-------{service.FindCarByCarCode(code).CarName}--------{service.FindCarByCarCode(code).CarCode}");

Console.WriteLine("-----------------------------------");
Console.WriteLine("Search cars by min and max speed");
Console.Write("MinSpeed : ");
double minspeed = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("MaxSpped : ");
double maxspped = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("----- RESULT -----");
foreach (var car in service.FindCarsBySpeedInterval(minspeed, maxspped))
{
    Console.WriteLine($"{car.CarId}-------{car.CarName}--------{car.CarCode}");
}

Console.WriteLine("-----------------------------------");
service.ShowAllCars();


Car AddCar()
{
    Console.WriteLine("-------------------------------");
    Console.Write("Car Id: ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Car Name: ");
    string name = Console.ReadLine();
    Console.Write("Car Speed: ");
    double speed = Convert.ToDouble(Console.ReadLine());
    Car car = new Car(id, name, speed);
    return car;
}

