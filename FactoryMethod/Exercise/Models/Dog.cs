using FactoryMethod.Exercise.Interfaces;

namespace FactoryMethod.Exercise.Models
{
    public class Dog : IAnimal
    {
        public string GetName()
        {
            return "Dog";
        }
    }
}