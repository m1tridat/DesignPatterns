using Builder.Interfaces;
using Builder.Models;

namespace Builder.Builders;

public class ManualBuilder : ICarBuilder
{
    private Manual _manual;

    public ManualBuilder()
    {
        _manual = new Manual();
    }
    public void Reset()
    {
        _manual = new Manual();
    }

    public void SetEngine(Engine engine)
    {
        _manual.EngineInstructions = engine.Instructions;
    }

    public void SetSeats(int seatsCount)
    {
        _manual.SeatsCount = seatsCount.ToString();
    }

    public void SetGps()
    {
        _manual.GpsInstructions = "GPS instructions";
    }

    public Manual GetResult()
    {
        return _manual;
    }
}