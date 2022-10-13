using FactoryMethod.Exercise.Interfaces;
using FactoryMethod.Exercise.Models;

namespace FactoryMethod.Exercise.Factories
{
    public class CatCreator : IAnimalCreator
    {
        public IAnimal Create()
        {
            return new Cat();
        }
    }
}