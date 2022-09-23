using CarLotSimulatorApp1;

var carLot1 = new CarLot();

Console.WriteLine();
Console.WriteLine("---------------------Car 1-----------------------------");
Console.WriteLine();

var f150 = new Car(); 
    f150.Year = 2015;
    f150.Make = "Ford";
    f150.Model = "F150";
    f150.EngineNoise = "88 decibels";
    f150.HonkNoise = "100-110 decibels";
    f150.IsDriveable = true;

f150.MakeEngineNoise();
f150.MakeHonkNoise();

carLot1.ListOfCars.Add(f150);

Console.WriteLine();
Console.WriteLine($"Number of cars in the lot: {CarLot.NumberOfCars}");


Console.WriteLine();
Console.WriteLine("---------------------Car 2-----------------------------");
Console.WriteLine();

var vanquish = new Car()
{
    Year = 2022,
    Make = "Aston Martin",
    Model = "Vanquish",
    EngineNoise = "well over 150 decibels",
    HonkNoise = "around 100 decibels",
    IsDriveable = true
};

vanquish.MakeEngineNoise();
vanquish.MakeHonkNoise();

carLot1.ListOfCars.Add(vanquish);

Console.WriteLine();
Console.WriteLine($"Number of cars in the lot: {CarLot.NumberOfCars}");


Console.WriteLine();
Console.WriteLine("---------------------Car 3-----------------------------");
Console.WriteLine();

var flyingCar = new Car(2050, "Future Company", "Flying Car", "nearly 0 decibels", "approximately 130 decibels", false);

flyingCar.MakeEngineNoise();
flyingCar.MakeHonkNoise();

carLot1.ListOfCars.Add(flyingCar);

Console.WriteLine();
Console.WriteLine($"Number of cars in the lot: {CarLot.NumberOfCars}");

Console.WriteLine();
Console.WriteLine("--------------------Car Lot-----------------------------");
Console.WriteLine();

Console.WriteLine("List of Year, Make and Model for each vehicle in carLot1:");
Console.WriteLine();

foreach (var vehicle in carLot1.ListOfCars)
{
    Console.WriteLine($"{vehicle.Year} - {vehicle.Make} - {vehicle.Model}");
}
