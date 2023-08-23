using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Products
{
    public abstract class Device : IDevice
    {
        public string name { get; set; }
        public string cpu { get; set; }
        public int amountRam { get; set; }
        public double? displaySize { get; set; }
        public string gpu { get; set; }

        public IAppearanceFactory appearance { get; set; }
        public IMaterial material { get; set; }
        public IFinishing finishing { get; set; }       

        public void ArrangeAppearance() 
        {
            Console.WriteLine("Configuring appearance...");
            material = appearance.CreateMaterial();
            finishing = appearance.CreateFinishing();
            Console.WriteLine("Your " + name + " is made of " + finishing.name + " " + material.name);
        }

        public void Assemble()
        {
            Console.WriteLine("Your " + name + " is being assembled");
            ArrangeAppearance();
        }
        public void Deliver()
        {
            Console.WriteLine("Your " + name + " has been sent");
        }
    }
}
