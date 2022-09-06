
namespace OQueAssistir
{
    partial class Incluir_Filme
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
            this.labelNomeFilme = new System.Windows.Forms.Label();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.labelGeneroFilme = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.labelSinopse = new System.Windows.Forms.Label();
            this.checkBoxSinopse = new System.Windows.Forms.CheckBox();
            this.textBoxSinopse = new System.Windows.Forms.TextBox();
            this.BtCancelar = new FontAwesome.Sharp.IconButton();
            this.BtIncluir = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelNomeFilme
            // 
            this.labelNomeFilme.AutoSize = true;
            this.labelNomeFilme.Location = new System.Drawing.Point(94, 65);
            this.labelNomeFilme.Name = "labelNomeFilme";
            this.labelNomeFilme.Size = new System.Drawing.Size(74, 13);
            this.labelNomeFilme.TabIndex = 0;
            this.labelNomeFilme.Text = "Nome do filme";
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(219, 58);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(191, 20);
            this.txtNomeFilme.TabIndex = 1;
            // 
            // labelGeneroFilme
            // 
            this.labelGeneroFilme.AutoSize = true;
            this.labelGeneroFilme.Location = new System.Drawing.Point(94, 120);
            this.labelGeneroFilme.Name = "labelGeneroFilme";
            this.labelGeneroFilme.Size = new System.Drawing.Size(42, 13);
            this.labelGeneroFilme.TabIndex = 2;
            this.labelGeneroFilme.Text = "Gênero";
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Comédia",
            "Romance",
            "Suspense",
            "Sensual kk",
            "Terror",
            "Variados"});
            this.cbGenero.Location = new System.Drawing.Point(219, 120);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 3;
            // 
            // labelSinopse
            // 
            this.labelSinopse.AutoSize = true;
            this.labelSinopse.Location = new System.Drawing.Point(94, 180);
            this.labelSinopse.Name = "labelSinopse";
            this.labelSinopse.Size = new System.Drawing.Size(115, 13);
            this.labelSinopse.TabIndex = 4;
            this.labelSinopse.Text = "Deseja incluir sinopse?";
            // 
            // checkBoxSinopse
            // 
            this.checkBoxSinopse.AutoSize = true;
            this.checkBoxSinopse.Location = new System.Drawing.Point(219, 180);
            this.checkBoxSinopse.Name = "checkBoxSinopse";
            this.checkBoxSinopse.Size = new System.Drawing.Size(43, 17);
            this.checkBoxSinopse.TabIndex = 5;
            this.checkBoxSinopse.Text = "Sim";
            this.checkBoxSinopse.UseVisualStyleBackColor = true;
            this.checkBoxSinopse.CheckedChanged += new System.EventHandler(this.checkBoxSinopse_CheckedChanged);
            // 
            // textBoxSinopse
            // 
            this.textBoxSinopse.Location = new System.Drawing.Point(219, 214);
            this.textBoxSinopse.Multiline = true;
            this.textBoxSinopse.Name = "textBoxSinopse";
            this.textBoxSinopse.Size = new System.Drawing.Size(294, 136);
            this.textBoxSinopse.TabIndex = 6;
            // 
            // BtCancelar
            // 
            this.BtCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtCancelar.IconColor = System.Drawing.Color.Black;
            this.BtCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtCancelar.Location = new System.Drawing.Point(219, 382);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 8;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtIncluir
            // 
            this.BtIncluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtIncluir.IconColor = System.Drawing.Color.Black;
            this.BtIncluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtIncluir.Location = new System.Drawing.Point(335, 382);
            this.BtIncluir.Name = "BtIncluir";
            this.BtIncluir.Size = new System.Drawing.Size(75, 23);
            this.BtIncluir.TabIndex = 7;
            this.BtIncluir.Text = "Incluir";
            this.BtIncluir.UseVisualStyleBackColor = true;
            this.BtIncluir.Click += new System.EventHandler(this.BtIncluir_Click);
            // 
            // Incluir_Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtIncluir);
            this.Controls.Add(this.textBoxSinopse);
            this.Controls.Add(this.checkBoxSinopse);
            this.Controls.Add(this.labelSinopse);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.labelGeneroFilme);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.labelNomeFilme);
            this.Name = "Incluir_Filme";
            this.Text = "Incluir Filme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeFilme;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.Label labelGeneroFilme;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label labelSinopse;
        private System.Windows.Forms.CheckBox checkBoxSinopse;
        private System.Windows.Forms.TextBox textBoxSinopse;
        private FontAwesome.Sharp.IconButton BtIncluir;
        private FontAwesome.Sharp.IconButton BtCancelar;
    }
}