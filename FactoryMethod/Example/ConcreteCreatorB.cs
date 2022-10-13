namespace FactoryMethod.Example
{
    public class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

    public class ConcreteProductB : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProductB}";
        }
    }
}