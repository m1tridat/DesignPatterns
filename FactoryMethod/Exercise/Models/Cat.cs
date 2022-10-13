using FactoryMethod.Exercise.Interfaces;

namespace FactoryMethod.Exercise.Models
{
    public class Cat : IAnimal
    {
        public string GetName()
        {
            return "Cat";
        }
    }
}