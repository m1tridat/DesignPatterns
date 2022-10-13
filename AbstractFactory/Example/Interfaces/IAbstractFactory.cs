namespace AbstractFactory.Example.Interfaces
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}