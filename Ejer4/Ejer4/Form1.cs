using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double total;
        private int calculo;
        public Form1()
        {
            InitializeComponent();
        }
        //  DAMOS VALORES A LOS BOTONES PARA QUE SE MUESTREN EN EL CUADRO DE TEXTO
        private void b0_Click(object sender, EventArgs e)
        {
            if (Resultado.Text == string.Empty)
            {
                Resultado.Text = "";
            }
            else
            {
                Resultado.Text += b0.Text;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + b1.Text; 
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + b2.Text; 
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + b3.Text; 
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + b4.Text ; 
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + b5.Text; 
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + b6.Text;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + b7.Text; 
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + b8.Text; 
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + b9.Text;
        }

        private void bC_Click(object sender, EventArgs e)
        {       // COMA
            Resultado.Text = Resultado.Text + ",";
        }

        private void bE_Click(object sender, EventArgs e)
        {       //  ENTRE
            calculo = 4;
            valor1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
        }

        private void bX_Click(object sender, EventArgs e)
        {       // POR
            calculo = 3;
            valor1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
        }

        private void bMn_Click(object sender, EventArgs e)
        {       //  MENOS
            calculo = 2;
            valor1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
        }

        private void bMa_Click(object sender, EventArgs e)
        {       //  MAS
            calculo = 1;
            valor1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
        }

        private void bI_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(Resultado.Text);

            switch (calculo)
            { 
                case 1: total = valor1 + valor2;
                    break;
                case 2: total = valor1 - valor2;
                    break;
                case 3: total = valor1 * valor2;
                    break;
                case 4: total = valor1 / valor2;
                    break;
            }

            Resultado.Text = total.ToString();           
        }

        private void bR_Click(object sender, EventArgs e)
        {
            Resultado.Text = "";
        }

    }
}
