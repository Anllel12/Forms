using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Ventana01 : Form
    {
        public String texto = "";

        public Ventana01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventana = new VentanaPrincipal();

            texto = texto+ textBox1.Text;

            ventana.cambiaNombre(texto);
            ventana.Show();
        }
    }
}
