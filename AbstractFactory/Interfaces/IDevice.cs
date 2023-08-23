using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IDevice
    {
        string name { get; set; }
        string cpu { get; set; }
        int amountRam { get; set; }
        double? displaySize { get; set; }
        string gpu { get; set; }
        IMaterial material { get; set; }
        IFinishing finishing { get; set; }

        void ArrangeAppearance();

        void Assemble();
        void Deliver();
    }
}
