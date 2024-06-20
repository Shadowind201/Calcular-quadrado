using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_quadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtValor.Text, out float lado))
            {
                float area = lado * lado;

                lblResultado.Text = "A area do quadrado: " + area;
            }
            else
            {
                MessageBox.Show("Entrada invalida. Por favor digite um numero valido");
            }
        }
    }
}
