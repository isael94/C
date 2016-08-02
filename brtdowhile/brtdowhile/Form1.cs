using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brtdowhile
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int cantAlumnos, nota;
            Double promedio = 0;

            //Entrada de datos
            cantAlumnos = Convert.ToInt32(txtalumnos.Text);
            //Proceso
            //Implementar un bucle for
            for(int i=0; i < cantAlumnos; i++)
            {
                //Leer la nota del alumno
                do
                {
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del alumno " + (i + 1), "Registro notas"));
                } while (nota < 0 || nota > 20);

                promedio = promedio + nota;
                
            }
            txtPromedio.Text = Convert.ToString(promedio / cantAlumnos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            txtalumnos.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
