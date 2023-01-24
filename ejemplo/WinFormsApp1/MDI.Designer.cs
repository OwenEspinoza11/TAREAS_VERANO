namespace WinFormsApp1
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inssLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejemplosToolStripMenuItem
            // 
            this.ejemplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inssLToolStripMenuItem,
            this.utilidadToolStripMenuItem,
            this.totalToolStripMenuItem});
            this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
            this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ejemplosToolStripMenuItem.Text = "Ejemplos";
            // 
            // inssLToolStripMenuItem
            // 
            this.inssLToolStripMenuItem.Name = "inssLToolStripMenuItem";
            this.inssLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inssLToolStripMenuItem.Text = "InssL";
            this.inssLToolStripMenuItem.Click += new System.EventHandler(this.inssLToolStripMenuItem_Click);
            // 
            // utilidadToolStripMenuItem
            // 
            this.utilidadToolStripMenuItem.Name = "utilidadToolStripMenuItem";
            this.utilidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utilidadToolStripMenuItem.Text = "Utilidad";
            this.utilidadToolStripMenuItem.Click += new System.EventHandler(this.utilidadToolStripMenuItem_Click);
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.totalToolStripMenuItem.Text = "Total";
            this.totalToolStripMenuItem.Click += new System.EventHandler(this.totalToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Sistema Ejemplos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ejemplosToolStripMenuItem;
        private ToolStripMenuItem inssLToolStripMenuItem;
        private ToolStripMenuItem utilidadToolStripMenuItem;
        private ToolStripMenuItem totalToolStripMenuItem;
    }
}