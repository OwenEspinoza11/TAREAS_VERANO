using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            mtxtSubtotal.Clear();
            mtxtSubtotal.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num,total;
           

            num = double.Parse(mtxtSubtotal.Text);
           

            if (mtxtSubtotal.Text == "")
            {
                MessageBox.Show("No puede ser blanco", "Advertencia");
            }
      
            if (num >= 1 && num <= 5000)
            {
                if(rbtnContado.Checked == true && rbtnCredito.Checked == false)
                {
                    if(num >= 1 || num <= 500)
                    {
                        double des1 = num * 0.05;
                        total = num - des1;
                        txtTotal.Text = total.ToString();
                    }

                    if(num >= 501 && num <= 2000)
                    {
                        double des2 = num * 0.10;
                        total = num - des2;
                        txtTotal.Text = total.ToString();
                    }

                    if(num >= 2001)
                    {
                        double des3 = num * 0.15;
                        total = num - des3;
                        txtTotal.Text = total.ToString();
                    }

                }

                if (rbtnContado.Checked == false && rbtnCredito.Checked == true)
                {
                    double interes = num * 0.05;
                    total = num + interes;
                    txtTotal.Text = total.ToString();
                }
                if (rbtnContado.Checked == false && rbtnCredito.Checked == false)
                {
                    MessageBox.Show("Seleccione una opcion");

                }


            }



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtTotal.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
