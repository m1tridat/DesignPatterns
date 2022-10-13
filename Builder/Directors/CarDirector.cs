using Builder.Builders;
using Builder.Models;

namespace Builder.Directors;

public class CarDirector
{
    public Car ConstructNormalCar(CarBuilder builder)
    {
        var engine = new Engine("Toyota 1002", "Normal", "Toyota engine instructions");
        builder.SetEngine(engine);
        builder.SetGps();
        builder.SetSeats(4);

        return builder.GetResult();
    }

    public Manual ConstructManualForNormalCar(ManualBuilder builder, Car car)
    {
        var engine = car.Engine;
        builder.SetEngine(engine);
        if (car.Gps) builder.SetGps();
        builder.SetSeats(car.Seats);
        
        return builder.GetResult();
    }
}