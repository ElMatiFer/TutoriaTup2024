using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal abstract class Animal:IComparable
            {
            private string pelo;
            protected int nroDueño;
            private int edad;
            private string nombre;

            public string Nombre { get { return nombre; } set { nombre = value; } }
            
            public int Edad { get { return edad; } set { edad = value; } }

            public virtual string HacerRuido()
            {
            return "Hace ruido";
            }
            public abstract string ComportamientoPropio();

        public int CompareTo(object obj)
        {
            int ret = 0;
            if (obj != null)
            {              
                Animal aComparar = (Animal)obj;
                return Edad.CompareTo(aComparar.Edad) * -1;
            }
            return ret;
        }

    }
}
