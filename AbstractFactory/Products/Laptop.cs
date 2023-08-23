using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    public class Laptop: Device
    {
        public Laptop(IAppearanceFactory appearance)
        {
            name = "Laptop";
            cpu = "Intel Core i7";
            amountRam = 32;
            gpu = "Nvidia GeForce RTX 3070";
            displaySize = 17.3;
            this.appearance = appearance;
        }
    }
}
