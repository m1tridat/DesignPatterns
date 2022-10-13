using System;
using FactoryMethod.Exercise.Factories;
using FactoryMethod.Exercise.Interfaces;

namespace FactoryMethod.Exercise
{
    public class AnimalsClient
    {
        public void Main()
        {
            Console.WriteLine("Create and get dog name");
            CreateAndGetName(new DogCreator());
            
            Console.WriteLine("Create and get cat name");
            CreateAndGetName(new CatCreator());
        } 

        public void CreateAndGetName(IAnimalCreator creator)
        {
            Console.WriteLine("Animal name: " + creator.GetAnimalName());
        }
    }
}