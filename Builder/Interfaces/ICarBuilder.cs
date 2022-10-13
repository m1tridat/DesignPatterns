using Builder.Models;

namespace Builder.Interfaces;

public interface ICarBuilder
{
    public void Reset();
    public void SetEngine(Engine engine);
    public void SetSeats(int seatsCount);
    public void SetGps();
}