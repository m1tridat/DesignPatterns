namespace AbstractFactory.Example.Interfaces
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}