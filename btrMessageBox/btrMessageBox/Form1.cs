using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btrMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string nombre;

            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre: ", "Registro", "Nombre", 100, 0);
            MessageBox.Show("Bienvenido Usuario " + nombre,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult opc;

            opc = MessageBox.Show("¿Estas seguro?", "Salir del programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opc == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
