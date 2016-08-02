using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace brt.Ecuacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c,xu,xd;

            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtb.Text);
            if(a == 0)
            {
                txta.Clear();
                txtb.Clear();
                txtc.Clear();
                txtx1.Clear();
                txtx2.Clear();
                MessageBox.Show("Error el primer termino no puede ser igual a 0", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            xu = a;
            xd = b;
            xu = (-b + Math.Sqrt((b * b -( 4 * a * c))))/2*a;
            xd = (-b - Math.Sqrt((b * b - (4 * a * c))))/2*a;

            txtx1.Text = Convert.ToString(xu);
            txtx2.Text = Convert.ToString(xd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtx1.Clear();
            txtx2.Clear();

        }
    }
}
