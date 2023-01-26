namespace NotasEstudiante
{
    public partial class Form1 : Form
    {

        ListViewItem item;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4;
            string estado;

            n1 = double.Parse(mtxtNota1.Text);
            n2 = double.Parse(mtxtNota2.Text);
            n3 = double.Parse(mtxtNota3.Text);
            n4 = double.Parse(mtxtNota4.Text);

            if (mtxtNota1.Text == "" && mtxtNota2.Text == ""
                && mtxtNota3.Text == "" && mtxtNota4.Text == "")
            {
                MessageBox.Show("Ingrese un valor en las casillas");
            }


            if (n1 >= 0 || n2 >= 0 || n3 >= 0 || n4 >= 0 &&
               n1 <= 25 || n2 <= 25 || n4 <= 25 || n4 <= 25)
            {

                double nf;

                nf = n1 + n2 + n3 + n4;

            }

            ListViewItem fila = new ListViewItem(n1);
            fila.SubItems.Add(n2.ToString());
            fila.SubItems.Add(n3.ToString());
            fila.SubItems.Add(n4.ToString());
            fila.SubItems.Add(nf.ToString());
            
            
            lvDatos.Items.Add(fila);



        }











        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Medidas",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtNota1.Clear();
            mtxtNota2.Clear();
            mtxtNota3.Clear();
            mtxtNota4.Clear();
            mtxtNota1.Focus();
        }
    }
}