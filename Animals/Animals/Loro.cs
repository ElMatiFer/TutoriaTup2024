using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Loro : Animal
    {
        public override string ComportamientoPropio()
        {
            return "Mi nombre" + base.Nombre;
        }
        public override string HacerRuido()
        {
            return "Mi nombre es " + base.Nombre;
        }

    }
        
}
