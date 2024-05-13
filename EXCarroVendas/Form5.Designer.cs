namespace EXCarroVendas
{
    partial class Form5
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtResult.Location = new System.Drawing.Point(413, 115);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(223, 117);
            this.txtResult.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(264, 389);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 36);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(188, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um numero: ";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNum.Location = new System.Drawing.Point(413, 55);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(223, 26);
            this.txtNum.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(451, 389);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 36);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnWhile.Location = new System.Drawing.Point(163, 312);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(86, 43);
            this.btnWhile.TabIndex = 5;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDo.Location = new System.Drawing.Point(342, 313);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(107, 42);
            this.btnDo.TabIndex = 6;
            this.btnDo.Text = "DO While";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFor.Location = new System.Drawing.Point(532, 312);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(92, 43);
            this.btnFor.TabIndex = 7;
            this.btnFor.Text = "FOR";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(188, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultado fatoral do numero: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtResult);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Label label2;
    }
}