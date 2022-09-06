
namespace OQueAssistir
{
    partial class FormInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.LblResultadoJogo = new System.Windows.Forms.Label();
            this.Jogar = new FontAwesome.Sharp.IconButton();
            this.BtContinuar = new FontAwesome.Sharp.IconButton();
            this.BtFechar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(80, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chegou a hora da verdade, vamos ver quem vai escolher hoje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 8.25F);
            this.label2.Location = new System.Drawing.Point(189, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Par ou ímpar?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(190, 127);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(72, 20);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblResultadoJogo
            // 
            this.LblResultadoJogo.AutoSize = true;
            this.LblResultadoJogo.Location = new System.Drawing.Point(187, 227);
            this.LblResultadoJogo.Name = "LblResultadoJogo";
            this.LblResultadoJogo.Size = new System.Drawing.Size(35, 13);
            this.LblResultadoJogo.TabIndex = 4;
            this.LblResultadoJogo.Text = "label3";
            // 
            // Jogar
            // 
            this.Jogar.IconChar = FontAwesome.Sharp.IconChar.HandScissors;
            this.Jogar.IconColor = System.Drawing.Color.Black;
            this.Jogar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Jogar.IconSize = 20;
            this.Jogar.Location = new System.Drawing.Point(187, 174);
            this.Jogar.Name = "Jogar";
            this.Jogar.Size = new System.Drawing.Size(75, 23);
            this.Jogar.TabIndex = 5;
            this.Jogar.Text = "Jogar";
            this.Jogar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Jogar.UseVisualStyleBackColor = true;
            this.Jogar.Click += new System.EventHandler(this.Jogar_Click);
            // 
            // BtContinuar
            // 
            this.BtContinuar.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.BtContinuar.IconColor = System.Drawing.Color.Black;
            this.BtContinuar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtContinuar.IconSize = 15;
            this.BtContinuar.Location = new System.Drawing.Point(341, 252);
            this.BtContinuar.Name = "BtContinuar";
            this.BtContinuar.Size = new System.Drawing.Size(75, 23);
            this.BtContinuar.TabIndex = 6;
            this.BtContinuar.Text = "Continuar";
            this.BtContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtContinuar.UseVisualStyleBackColor = true;
            this.BtContinuar.Click += new System.EventHandler(this.BtContinuar_Click);
            // 
            // BtFechar
            // 
            this.BtFechar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtFechar.FlatAppearance.BorderSize = 0;
            this.BtFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtFechar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtFechar.IconColor = System.Drawing.Color.Black;
            this.BtFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtFechar.IconSize = 20;
            this.BtFechar.Location = new System.Drawing.Point(423, 2);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(39, 23);
            this.BtFechar.TabIndex = 7;
            this.BtFechar.UseVisualStyleBackColor = true;
            this.BtFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(474, 302);
            this.Controls.Add(this.BtFechar);
            this.Controls.Add(this.BtContinuar);
            this.Controls.Add(this.Jogar);
            this.Controls.Add(this.LblResultadoJogo);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormInicio_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label LblResultadoJogo;
        private FontAwesome.Sharp.IconButton Jogar;
        private FontAwesome.Sharp.IconButton BtContinuar;
        private FontAwesome.Sharp.IconButton BtFechar;
    }
}

