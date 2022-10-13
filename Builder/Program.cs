using Builder.Builders;
using Builder.Directors;

var carBuilder = new CarBuilder();
var manualBuilder = new ManualBuilder();

var director = new CarDirector();
var car = director.ConstructNormalCar(carBuilder);
var gps = car.Gps ? "enabled" : "disabled";
Console.WriteLine($"Car with engine {car.Engine.Name}, with {car.Seats} seats and GPS {gps} were created");
var manual = director.ConstructManualForNormalCar(manualBuilder, car);
Console.WriteLine("Car manual is created.");
Console.WriteLine($"Engine instructions: {manual.EngineInstructions}");
Console.WriteLine($"Seats: {manual.SeatsCount}");
Console.WriteLine($"Gps instructions: {manual.GpsInstructions}");