using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Appearance
{
    public class Engraved : IFinishing
    {
        public string name => "Engraved";
    }
}
