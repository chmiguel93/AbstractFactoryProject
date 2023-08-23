using AbstractFactory;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using System;
using static AbstractFactory.Enums;

namespace AbstractFactoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Unilago apple = new Apple();
            Unilago acer = new Acer();

            IDevice device1 = apple.BuyDevice(DeviceType.Desktop);
            Console.WriteLine("\n");

            IDevice device2 = acer.BuyDevice(DeviceType.Laptop);
            Console.WriteLine("\n");

            Console.WriteLine("device1 material " + device1.material.name);
            Console.WriteLine("device2 material " + device2.material.name);
            Console.ReadKey();
        }
    }
}
