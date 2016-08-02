using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btr.Validations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if (is_validate())
            {
                erroricono.Clear();
                MessageBox.Show("Los datos estan validados","Validaciones",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool is_validate() {
            bool no_error = true;

            if(txtnombre.Text == string.Empty)
            {
                erroricono.SetError(txtnombre, "Ingrese su nombre");
                no_error = false;
            }
            else {
                try
                {
                    int i = Convert.ToInt32(txtedad.Text);
                }
                catch
                {
                    erroricono.Clear();
                    erroricono.SetError(txtedad, "Ingrese edad");
                    return false;
                }

                try
                {
                    double j = Convert.ToDouble(txtsalario.Text);
                }
                catch
                {
                    erroricono.Clear();
                    erroricono.SetError(txtsalario, "Ingrese un salario valido");
                    return false;
                }
            }

            return no_error;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtedad.Clear();
            txtsalario.Clear();
            txtdescripcion.Clear();
        }

        private void llblsalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
