using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    internal class Dog
    {
        public string Nombre { get; private set; }

        public string Diagnostico { get; set; }

        private int contacto;

        public Dog (string nombre, string diagnostico, int contacto)
        {
            this.Nombre = nombre;
            this.Diagnostico = diagnostico;
            this.contacto = contacto;
        }

        public int VerContacto()
        {
            return contacto;
        }
    }
}
