﻿using System;
using AbstractFactory.Example.Factories;
using AbstractFactory.Example.Interfaces;

namespace AbstractFactory.Example
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();
            
            Console.WriteLine("Client: Testing the same client code with the first factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        private void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();
            
            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}