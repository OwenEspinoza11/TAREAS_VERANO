﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ing, egr, ut;
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("No puede ser blanco", "Advertencia");
            }
            else {
              ing=double.Parse(textBox1.Text);
              egr=double.Parse(textBox2.Text);
              if(ing >= 4800 && ing <= 500000)
                {
                    if (egr <= ing)
                    {
                        ut = ing - egr;
                        textBox3.Text = ut.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El egreso no puede ser mayor al ingreso", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Debe estar entre 4800 y 500000", "Error");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }
    }
}
