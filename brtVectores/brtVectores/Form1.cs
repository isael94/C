using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brtVectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int[] notas = new int[5];
            //Especificar las notas
            notas[0] = 15;
            notas[1] = 10;
            notas[2] = 18;
            notas[3] = 19;
            notas[4] = 11;

            int suma = 0;
            double promedio;
            //Proceso
            cboNotas.Items.Clear();
            for(int i = 0; i < 5; i++)
            {
                //Mostrar las notas en el combobox
                cboNotas.Items.Add(notas[i]);
                suma = suma + notas[i];
            }
            promedio = suma / 5;

            txtPromedio.Text = Convert.ToString(promedio);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
