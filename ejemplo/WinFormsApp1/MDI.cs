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
    public partial class MDI : Form
    {
     Form1 x = new Form1();
        Form2 u=new Form2();
        Form3 v=new Form3();
        public MDI()
        {
            InitializeComponent();
        }

        private void inssLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MdiParent = this;
            x.Show();

        }

        private void utilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u.MdiParent = this;
            u.Show();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.MdiParent = this;
            v.Show();
        }
    }
}
