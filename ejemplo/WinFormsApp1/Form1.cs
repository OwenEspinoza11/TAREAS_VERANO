namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ingr, il,ip;
            if (textBox1.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else
            {
                ingr = double.Parse(textBox1.Text);
                if (ingr >= 4800 && ingr <= 500000)
                {
                    if(comboBox1.Text.Equals("Laboral"))
                    {
                        il = ingr * 0.07;
                        textBox2.Text = il.ToString();
                    }
                    if (comboBox1.Text.Equals("Patronal"))
                    {
                        ip = ingr * 0.22;
                        textBox3.Text=ip.ToString();
                    }
                    
                }
                else
                {
                    MessageBox.Show("rango entre 4800 y 500000", "Error");
                    textBox1.Text = "";
                    textBox1.Focus();
                }

            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}