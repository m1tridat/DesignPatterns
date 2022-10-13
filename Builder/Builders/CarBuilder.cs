using Builder.Interfaces;
using Builder.Models;

namespace Builder.Builders;

public class CarBuilder : ICarBuilder
{
    private Car _car;

    public CarBuilder()
    {
        _car = new Car();
    }
    
    public void Reset()
    {
        _car = new Car();
    }

    public void SetEngine(Engine engine)
    {
        _car.Engine = engine;
    }

    public void SetSeats(int seatsCount)
    {
        _car.Seats = seatsCount;
    }

    public void SetGps()
    {
        _car.Gps = true;
    }

    public Car GetResult()
    {
        return _car;
    }
}