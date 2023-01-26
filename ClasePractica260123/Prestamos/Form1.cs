namespace Prestamos
{
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto, inteCons, inteVeh, inteViv, plazo;

            if (mtxtMonto.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (cboTipoPrestamo.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (mtxtPlazo.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else
            {
                monto = double.Parse(mtxtMonto.Text);
                plazo = double.Parse(mtxtPlazo.Text);

                if (monto >= 100 && monto <= 5000)
                {
                    if (cboTipoPrestamo.Text.Equals("Consumo"))
                    {
                        inteCons = monto * 0.24 + monto / plazo;
                        txtCuota.Text = inteCons.ToString();
                    }

                }
                if (monto >= 5000 && monto <= 65000)
                {
                    if (cboTipoPrestamo.Text.Equals("Vehiculo"))
                    {
                        inteVeh = monto * 0.18 + monto / plazo;
                        txtCuota.Text = inteVeh.ToString();
                    }

                }
                if (monto >= 10000 && monto <= 350000)
                {
                    if (cboTipoPrestamo.Text.Equals("Vivienda"))
                    {
                        inteViv = monto * 0.12 + monto / plazo;
                        txtCuota.Text = inteViv.ToString();
                    }

                }









            }



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtMonto.Clear();
            mtxtPlazo.Clear();
            txtCuota.Clear();
            mtxtMonto.Focus();
        }

        

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            txtCuota.Enabled = false;
        }
    }
}