using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Products
{
    public class Pc: Device
    {
        public Pc(IAppearanceFactory appearance) 
        {
            name = "PC";
            cpu = "Intel Core i9";
            amountRam = 64;
            gpu = "Nvidia GeForce RTX 3090";
            this.appearance = appearance;
        }
    }
}
