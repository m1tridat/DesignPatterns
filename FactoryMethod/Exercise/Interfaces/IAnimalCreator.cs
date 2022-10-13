namespace FactoryMethod.Exercise.Interfaces
{
    public interface IAnimalCreator
    {
        public IAnimal Create();

        public string GetAnimalName()
        {
            var animal = Create();
            return animal.GetName();
        }
    }
}