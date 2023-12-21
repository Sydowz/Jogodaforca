namespace JogoForca
{
    partial class Form1
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.lblErros = new System.Windows.Forms.Label();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.btnTentar = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.lblLetrasTentadas = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Impact", 10F);
            this.btnSair.Location = new System.Drawing.Point(34, 33);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 83);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Font = new System.Drawing.Font("Impact", 8F);
            this.btnNovoJogo.Location = new System.Drawing.Point(34, 122);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(86, 87);
            this.btnNovoJogo.TabIndex = 14;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click_1);
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Font = new System.Drawing.Font("Impact", 10F);
            this.lblErros.Location = new System.Drawing.Point(136, 278);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(61, 25);
            this.lblErros.TabIndex = 13;
            this.lblErros.Text = "Erros: ";
            this.lblErros.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Font = new System.Drawing.Font("Impact", 25F);
            this.lblPalavra.Location = new System.Drawing.Point(250, 107);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(0, 63);
            this.lblPalavra.TabIndex = 12;
            // 
            // btnTentar
            // 
            this.btnTentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTentar.Font = new System.Drawing.Font("Impact", 17F);
            this.btnTentar.Location = new System.Drawing.Point(256, 387);
            this.btnTentar.Name = "btnTentar";
            this.btnTentar.Size = new System.Drawing.Size(264, 53);
            this.btnTentar.TabIndex = 11;
            this.btnTentar.Text = "Tentar";
            this.btnTentar.UseVisualStyleBackColor = true;
            this.btnTentar.Click += new System.EventHandler(this.btnTentar_Click_1);
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(141, 336);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(500, 26);
            this.txtLetra.TabIndex = 10;
            // 
            // lblLetrasTentadas
            // 
            this.lblLetrasTentadas.AutoSize = true;
            this.lblLetrasTentadas.Font = new System.Drawing.Font("Impact", 10F);
            this.lblLetrasTentadas.Location = new System.Drawing.Point(136, 253);
            this.lblLetrasTentadas.Name = "lblLetrasTentadas";
            this.lblLetrasTentadas.Size = new System.Drawing.Size(147, 25);
            this.lblLetrasTentadas.TabIndex = 9;
            this.lblLetrasTentadas.Text = "Letras Tentadas: ";
            this.lblLetrasTentadas.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Impact", 10F);
            this.lblTema.Location = new System.Drawing.Point(136, 303);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(59, 25);
            this.lblTema.TabIndex = 16;
            this.lblTema.Text = "Tema:";
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(801, 554);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.lblPalavra);
            this.Controls.Add(this.btnTentar);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.lblLetrasTentadas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Button btnTentar;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label lblLetrasTentadas;
        private System.Windows.Forms.Label lblTema;
    }
}

