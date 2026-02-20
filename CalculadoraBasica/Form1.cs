using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);
            double resultado = n1 + n2;

            lblResultado.Text = "Resultado: " + resultado;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);
            double resultado = n1 - n2;

            lblResultado.Text = "Resultado: " + resultado;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);
            double resultado = n1 * n2;

            lblResultado.Text = "Resultado: " + resultado;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);

            if (n2 != 0)
            {
                double resultado = n1 / n2;
                lblResultado.Text = "Resultado: " + resultado;
            }
            else
            {
                lblResultado.Text = "No se puede dividir entre 0";
            }
        }
    }
}
