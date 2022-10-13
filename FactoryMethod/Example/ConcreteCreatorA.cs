namespace FactoryMethod.Example
{
    public class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteProductA : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProductA}";
        }
    }
}