using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //  CHECKEAMOS EL SISTEMA OPERATIVO SELECCIONADO
            string sistema = "";
            if (radioButton1.Checked)
            { sistema = radioButton1.Text; }
            else if (radioButton2.Checked)
            { sistema = radioButton2.Text; }
            else if (radioButton3.Checked)
            { sistema = radioButton3.Text; }

            //  CHECKEAMOS LA ESPECIALIDAD SELECCIONADA
            string especialidad = "";
            if (checkBox1.Checked)
            { especialidad = checkBox1.Text; }
            if (checkBox2.Checked)
            { especialidad = checkBox2.Text; }
            if (checkBox3.Checked)
            { especialidad = checkBox3.Text; }

            //  MOSTRAMOS TODOS LOS DATOS EN PANTALLA
            MessageBox.Show("Sistema: " + sistema + "\nEspecialidad: " + especialidad + "\nHoras dedicadas: " + trackBar1.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = "" + trackBar1.Value;
        }

    }
}
