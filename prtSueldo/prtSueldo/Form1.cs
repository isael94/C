using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prtSueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblnombre.Visible = false;
            lblpago.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            String nombre;
            int ht;
            double ph, pagot;
            ht = Int32.Parse(txthoras.Text);
            ph = Double.Parse(txtpago.Text);
            nombre = txtNombre.Text;

            pagot = ph * ht;


            lblnombre.Text = Convert.ToString("Nombre: " +nombre);
            lblnombre.Visible = true;

            lblpago.Text = Convert.ToString("Pago: $"+pagot);
            lblpago.Visible = true;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txthoras.Clear();
            txtpago.Clear();
            txtNombre.Clear();
            lblnombre.Visible = false;
            lblpago.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
