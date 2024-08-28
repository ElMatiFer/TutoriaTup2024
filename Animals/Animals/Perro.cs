using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals
{
    internal class Perro : Animal
    {
        public override string HacerRuido()
        {
            return "wof wof";
        }

        public override string ComportamientoPropio()
        {
            return HacerRuido() + HacerRuido();
        }   

        
    }

}
