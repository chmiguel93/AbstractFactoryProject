using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Products
{
    public class MacBookPro : Device
    {
        public MacBookPro(IAppearanceFactory appearance)
        {
            name = "Macbook Pro";
            cpu = "Intel Core i9";
            amountRam = 64;
            this.appearance = appearance;
        }
    }
}
