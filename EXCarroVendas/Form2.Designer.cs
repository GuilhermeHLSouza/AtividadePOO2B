namespace EXCarroVendas
{
    partial class PgMenu
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.competiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salarioToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.OpenCarro,
            this.competiçãoToolStripMenuItem,
            this.loopingToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.toolStripSeparator1});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // salarioToolStripMenuItem
            // 
            this.salarioToolStripMenuItem.Name = "salarioToolStripMenuItem";
            this.salarioToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.salarioToolStripMenuItem.Text = "Salario";
            this.salarioToolStripMenuItem.Click += new System.EventHandler(this.salarioToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // OpenCarro
            // 
            this.OpenCarro.Name = "OpenCarro";
            this.OpenCarro.Size = new System.Drawing.Size(139, 22);
            this.OpenCarro.Text = "Carro";
            this.OpenCarro.Click += new System.EventHandler(this.OpenCarro_Click);
            // 
            // competiçãoToolStripMenuItem
            // 
            this.competiçãoToolStripMenuItem.Name = "competiçãoToolStripMenuItem";
            this.competiçãoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.competiçãoToolStripMenuItem.Text = "Competição";
            this.competiçãoToolStripMenuItem.Click += new System.EventHandler(this.competiçãoToolStripMenuItem_Click);
            // 
            // loopingToolStripMenuItem
            // 
            this.loopingToolStripMenuItem.Name = "loopingToolStripMenuItem";
            this.loopingToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loopingToolStripMenuItem.Text = "Looping";
            this.loopingToolStripMenuItem.Click += new System.EventHandler(this.loopingToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // PgMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PgMenu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenCarro;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loopingToolStripMenuItem;
    }
}