using System;
using System.Threading;
using Singleton.Example;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Example.Singleton.GetInstance();
            var singleton2 = Example.Singleton.GetInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Singleton works");
            }
            else
            {
                Console.WriteLine("Singleton didn't work");
            }

            var thread1 = new Thread(() =>
            {
                TestSingleton("thread1");
            });
            
            var thread2 = new Thread(() =>
            {
                TestSingleton("thread2");
            });

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }

        public static void TestSingleton(string value)
        {
            var singleton = ThreadSafeSingleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}