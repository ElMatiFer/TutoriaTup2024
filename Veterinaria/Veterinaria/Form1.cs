using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria
{
    public partial class Veterinaria : Form
    {
        public int contador = 0;
        public Veterinaria()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Dog perro = new Dog(tbNombrePerro.Text,tbDiagnostico.Text, Convert.ToInt32(tbContactoD.Text));

            if (contador < 4)
            {
                cbListaDog.Items.Add(perro.Nombre);
                contador++;                
            }
            else
            { 
                btnGuardar.Enabled = false;
            } 

            if (cbListaDog.SelectedItem)
            {
                lbData.Items.Add("hola estoy aca");
            }

        }
        //Pruebaaaa
        
    }
}
