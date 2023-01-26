namespace Prestamos
{
    partial class frmPrestamos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtMonto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.mtxtPlazo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto";
            // 
            // mtxtMonto
            // 
            this.mtxtMonto.Location = new System.Drawing.Point(51, 84);
            this.mtxtMonto.Mask = "000000";
            this.mtxtMonto.Name = "mtxtMonto";
            this.mtxtMonto.Size = new System.Drawing.Size(100, 23);
            this.mtxtMonto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de prestamo";
            // 
            // cboTipoPrestamo
            // 
            this.cboTipoPrestamo.FormattingEnabled = true;
            this.cboTipoPrestamo.Items.AddRange(new object[] {
            "Consumo",
            "Vehiculo",
            "Vivienda"});
            this.cboTipoPrestamo.Location = new System.Drawing.Point(229, 84);
            this.cboTipoPrestamo.Name = "cboTipoPrestamo";
            this.cboTipoPrestamo.Size = new System.Drawing.Size(121, 23);
            this.cboTipoPrestamo.TabIndex = 3;
            // 
            // mtxtPlazo
            // 
            this.mtxtPlazo.Location = new System.Drawing.Point(437, 84);
            this.mtxtPlazo.Mask = "000";
            this.mtxtPlazo.Name = "mtxtPlazo";
            this.mtxtPlazo.Size = new System.Drawing.Size(100, 23);
            this.mtxtPlazo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plazo (meses)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(83, 166);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuota mensual";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(229, 166);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(144, 266);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(100, 23);
            this.txtCuota.TabIndex = 10;
         
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtPlazo);
            this.Controls.Add(this.cboTipoPrestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtMonto);
            this.Controls.Add(this.label1);
            this.Name = "frmPrestamos";
            this.Text = "Tipos de prestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox mtxtMonto;
        private Label label2;
        private ComboBox cboTipoPrestamo;
        private MaskedTextBox mtxtPlazo;
        private Label label3;
        private Button btnCalcular;
        private Label label4;
        private Button btnLimpiar;
        private TextBox txtCuota;
    }
}