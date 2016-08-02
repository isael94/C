using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e){
            //Declaracion de variables
            double num1, num2;
            double suma, resta, multiplicacion, division, potencia, raiz;
            //Entrada de datos
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);
            //Proceso
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = num1 / num2;
            potencia = Math.Pow(num1, num2);
            raiz = Math.Pow(num1, (1 / num2));
            //Salida de informacion
            txtsuma.Text = Convert.ToString(suma);
            txtresta.Text = Convert.ToString(resta);
            txtmultiplicacion.Text = Convert.ToString(multiplicacion);
            txtdivision.Text = Convert.ToString(division);
            txtpotencia.Text = Convert.ToString(potencia);
            txtraiz.Text = Convert.ToString(raiz);
        }

        private void btnlimpiar_Click(object sender, EventArgs e){
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtsuma.Clear();
            txtresta.Clear();
            txtmultiplicacion.Clear();
            txtdivision.Clear();
            txtpotencia.Clear();
            txtraiz.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
