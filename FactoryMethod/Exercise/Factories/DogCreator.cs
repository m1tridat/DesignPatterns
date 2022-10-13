using FactoryMethod.Exercise.Interfaces;
using FactoryMethod.Exercise.Models;

namespace FactoryMethod.Exercise.Factories
{
    public class DogCreator : IAnimalCreator
    {
        public IAnimal Create()
        {
            return new Dog();
        }
    }
}