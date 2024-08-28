using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();

            Animal nuevo = new Perro();
            nuevo.Nombre = "Mirco";
            Animal nuevo1 = new Loro();
            nuevo1.Nombre = "Pepe";
            nuevo1.Edad = 40;
            Animal nuevo2 = new Loro();
            nuevo2.Nombre = "Marco";
            nuevo2.Edad = 5;
            Animal nuevo3 = new Perro();
            nuevo3.Nombre = "asd";
            nuevo3.Edad = 99;
            

            lista.Add(nuevo);
            lista.Add(nuevo1);
            lista.Add(nuevo2);
            lista.Add(nuevo3);
            lista.Sort();

            foreach (Animal a in  lista)
            {
               listBox1.Items.Add( $"{a} {a.Nombre} {a.Edad}");
            }
        }
    }
}
