
namespace OQueAssistir
{
    partial class Lista_Filmes
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
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.btListar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.Location = new System.Drawing.Point(116, 12);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.Size = new System.Drawing.Size(442, 358);
            this.dgvFilmes.TabIndex = 0;
            // 
            // btListar
            // 
            this.btListar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btListar.IconColor = System.Drawing.Color.Black;
            this.btListar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btListar.Location = new System.Drawing.Point(307, 390);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(75, 23);
            this.btListar.TabIndex = 1;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // Lista_Filmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.dgvFilmes);
            this.Name = "Lista_Filmes";
            this.Text = "Lista Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilmes;
        private FontAwesome.Sharp.IconButton btListar;
    }
}