using AbstractFactory.Example.Interfaces;
using AbstractFactory.Example.Models;

namespace AbstractFactory.Example.Factories
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}