
namespace OQueAssistir
{
    partial class Escolher_Filme
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
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.btAssistir = new FontAwesome.Sharp.IconButton();
            this.btCancelar = new FontAwesome.Sharp.IconButton();
            this.btBuscarGen = new FontAwesome.Sharp.IconButton();
            this.btBuscarNom = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
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
            this.cbGenero.Location = new System.Drawing.Point(143, 50);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gênero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do filme";
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(143, 108);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(172, 20);
            this.txtNomeFilme.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sinopse";
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(143, 195);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(367, 146);
            this.txtSinopse.TabIndex = 5;
            // 
            // btAssistir
            // 
            this.btAssistir.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btAssistir.IconColor = System.Drawing.Color.Black;
            this.btAssistir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAssistir.IconSize = 15;
            this.btAssistir.Location = new System.Drawing.Point(143, 373);
            this.btAssistir.Name = "btAssistir";
            this.btAssistir.Size = new System.Drawing.Size(76, 27);
            this.btAssistir.TabIndex = 6;
            this.btAssistir.Text = "Assitir";
            this.btAssistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAssistir.UseVisualStyleBackColor = true;
            this.btAssistir.Click += new System.EventHandler(this.btAssistir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btCancelar.IconColor = System.Drawing.Color.Black;
            this.btCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCancelar.IconSize = 15;
            this.btCancelar.Location = new System.Drawing.Point(239, 373);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(76, 27);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btBuscarGen
            // 
            this.btBuscarGen.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btBuscarGen.IconColor = System.Drawing.Color.Black;
            this.btBuscarGen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBuscarGen.IconSize = 20;
            this.btBuscarGen.Location = new System.Drawing.Point(286, 44);
            this.btBuscarGen.Name = "btBuscarGen";
            this.btBuscarGen.Size = new System.Drawing.Size(29, 30);
            this.btBuscarGen.TabIndex = 8;
            this.btBuscarGen.UseVisualStyleBackColor = true;
            this.btBuscarGen.Click += new System.EventHandler(this.btBuscarGen_Click);
            // 
            // btBuscarNom
            // 
            this.btBuscarNom.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btBuscarNom.IconColor = System.Drawing.Color.Black;
            this.btBuscarNom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBuscarNom.IconSize = 20;
            this.btBuscarNom.Location = new System.Drawing.Point(336, 108);
            this.btBuscarNom.Name = "btBuscarNom";
            this.btBuscarNom.Size = new System.Drawing.Size(29, 30);
            this.btBuscarNom.TabIndex = 9;
            this.btBuscarNom.UseVisualStyleBackColor = true;
            this.btBuscarNom.Click += new System.EventHandler(this.btBuscarNom_Click);
            // 
            // Escolher_Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(797, 493);
            this.Controls.Add(this.btBuscarNom);
            this.Controls.Add(this.btBuscarGen);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAssistir);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGenero);
            this.Name = "Escolher_Filme";
            this.Text = "Escolher Filme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSinopse;
        private FontAwesome.Sharp.IconButton btAssistir;
        private FontAwesome.Sharp.IconButton btCancelar;
        private FontAwesome.Sharp.IconButton btBuscarGen;
        private FontAwesome.Sharp.IconButton btBuscarNom;
    }
}