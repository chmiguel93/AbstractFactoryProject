using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Products
{
    public class MacPro : Device
    {
        public MacPro(IAppearanceFactory appearance)
        {
            name = "Mac Pro";
            cpu = "Intel Core i9";
            amountRam = 64;
            this.appearance = appearance;
        }
    }
}
