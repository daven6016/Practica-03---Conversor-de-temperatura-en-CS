using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_03___Conversor_de_temperatura_en_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void botonCF_Click(object sender, EventArgs e)
        {
            float centigrados = float.Parse(this.EntradaCelsius.Text);
            float fahrenheit = (centigrados * 9 / 5) + 32;
            this.EntradaFahrenheit.Text = fahrenheit.ToString();
        }

        private void botonFC_Click(object sender, EventArgs e)
        {
            float fahrenheit = float.Parse(this.EntradaFahrenheit.Text);
            float centigrados = (fahrenheit - 32) * 5 / 9;
            this.EntradaCelsius.Text = centigrados.ToString();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            EntradaCelsius.Clear();
            EntradaFahrenheit.Clear();
        }
    }
}
