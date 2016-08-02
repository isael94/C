using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brtStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Declarar las variables
            string cadena = txtCadena.Text;
            lblError.Visible = false;
            txtLongitud.Text = Convert.ToString(cadena.Length);

            txtPrimer.Text = cadena.Substring(0,1);

            txtUltimo.Text = cadena.Substring(cadena.Length-1,1);
            
                try {
                    txtSubcadena.Text = cadena.Substring(1, 5);
                  

                }
                catch{
                    MessageBox.Show("Error la cadena tiene que tener mas de 6 letras", "Falla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblError.Show();
                    
                
            }
            
            txtPosicion.Text = Convert.ToString(cadena.IndexOf("A", 0) + 1);

            txtMayusculas.Text = cadena.ToUpper();

            txtMinusculas.Text = cadena.ToLower();

            txtEspacios.Text = cadena.Replace(" ", ""); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
