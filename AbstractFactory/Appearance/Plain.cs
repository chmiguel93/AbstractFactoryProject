using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Appearance
{
    public class Plain : IFinishing
    {
        public string name => "Plain";
    }
}
