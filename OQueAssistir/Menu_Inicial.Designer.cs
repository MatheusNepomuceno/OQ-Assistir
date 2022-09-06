
namespace OQueAssistir
{
    partial class Menu_Inicial
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
            this.panelCentral = new System.Windows.Forms.Panel();
            this.BtMinimizar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblTituloFormFilho = new System.Windows.Forms.Label();
            this.IconeFormAtual = new FontAwesome.Sharp.IconPictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.BtSair = new FontAwesome.Sharp.IconButton();
            this.BtListarFilmes = new FontAwesome.Sharp.IconButton();
            this.BtnInserir = new FontAwesome.Sharp.IconButton();
            this.BtnEscolher = new FontAwesome.Sharp.IconButton();
            this.panelLatSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtFechar = new FontAwesome.Sharp.IconButton();
            this.panelCentral.SuspendLayout();
            this.BtMinimizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconeFormAtual)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panelLatSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.Turquoise;
            this.panelCentral.Controls.Add(this.BtMinimizar);
            this.panelCentral.Controls.Add(this.panel1);
            this.panelCentral.Controls.Add(this.panelSuperior);
            this.panelCentral.Controls.Add(this.panelLateral);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1057, 571);
            this.panelCentral.TabIndex = 0;
            // 
            // BtMinimizar
            // 
            this.BtMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtMinimizar.Controls.Add(this.pictureBox2);
            this.BtMinimizar.Controls.Add(this.label1);
            this.BtMinimizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtMinimizar.Location = new System.Drawing.Point(171, 110);
            this.BtMinimizar.Name = "BtMinimizar";
            this.BtMinimizar.Size = new System.Drawing.Size(886, 461);
            this.BtMinimizar.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OQueAssistir.Properties.Resources.kisspng_film_screening_night_cinema_child_movie_5abbd494b40fe5_3930240615222590927375;
            this.pictureBox2.Location = new System.Drawing.Point(287, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Não sabe que filme escolher de sua lista? Então seja bem-vindo ao";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(171, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 10);
            this.panel1.TabIndex = 2;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelSuperior.Controls.Add(this.BtFechar);
            this.panelSuperior.Controls.Add(this.iconButton1);
            this.panelSuperior.Controls.Add(this.lblTituloFormFilho);
            this.panelSuperior.Controls.Add(this.IconeFormAtual);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(171, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(886, 100);
            this.panelSuperior.TabIndex = 1;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(799, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(33, 23);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblTituloFormFilho
            // 
            this.lblTituloFormFilho.AutoSize = true;
            this.lblTituloFormFilho.Location = new System.Drawing.Point(67, 41);
            this.lblTituloFormFilho.Name = "lblTituloFormFilho";
            this.lblTituloFormFilho.Size = new System.Drawing.Size(32, 13);
            this.lblTituloFormFilho.TabIndex = 1;
            this.lblTituloFormFilho.Text = "Inicio";
            // 
            // IconeFormAtual
            // 
            this.IconeFormAtual.BackColor = System.Drawing.Color.LightSeaGreen;
            this.IconeFormAtual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconeFormAtual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconeFormAtual.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconeFormAtual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconeFormAtual.IconSize = 34;
            this.IconeFormAtual.Location = new System.Drawing.Point(15, 26);
            this.IconeFormAtual.Name = "IconeFormAtual";
            this.IconeFormAtual.Size = new System.Drawing.Size(34, 39);
            this.IconeFormAtual.TabIndex = 0;
            this.IconeFormAtual.TabStop = false;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelLateral.Controls.Add(this.BtSair);
            this.panelLateral.Controls.Add(this.BtListarFilmes);
            this.panelLateral.Controls.Add(this.BtnInserir);
            this.panelLateral.Controls.Add(this.BtnEscolher);
            this.panelLateral.Controls.Add(this.panelLatSuperior);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(171, 571);
            this.panelLateral.TabIndex = 0;
            // 
            // BtSair
            // 
            this.BtSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtSair.FlatAppearance.BorderSize = 0;
            this.BtSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSair.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.BtSair.IconColor = System.Drawing.Color.Black;
            this.BtSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtSair.IconSize = 30;
            this.BtSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSair.Location = new System.Drawing.Point(0, 241);
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(171, 47);
            this.BtSair.TabIndex = 6;
            this.BtSair.Text = "Sair                   ";
            this.BtSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtSair.UseVisualStyleBackColor = true;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click_1);
            // 
            // BtListarFilmes
            // 
            this.BtListarFilmes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtListarFilmes.FlatAppearance.BorderSize = 0;
            this.BtListarFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtListarFilmes.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtListarFilmes.IconColor = System.Drawing.Color.Black;
            this.BtListarFilmes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtListarFilmes.IconSize = 20;
            this.BtListarFilmes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtListarFilmes.Location = new System.Drawing.Point(0, 194);
            this.BtListarFilmes.Name = "BtListarFilmes";
            this.BtListarFilmes.Size = new System.Drawing.Size(171, 47);
            this.BtListarFilmes.TabIndex = 5;
            this.BtListarFilmes.Text = "Listar Filmes            ";
            this.BtListarFilmes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtListarFilmes.UseVisualStyleBackColor = true;
            this.BtListarFilmes.Click += new System.EventHandler(this.BtListarFilmes_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInserir.FlatAppearance.BorderSize = 0;
            this.BtnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInserir.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.BtnInserir.IconColor = System.Drawing.Color.Black;
            this.BtnInserir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInserir.IconSize = 30;
            this.BtnInserir.Location = new System.Drawing.Point(0, 147);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(171, 47);
            this.BtnInserir.TabIndex = 2;
            this.BtnInserir.Text = "Incluir Filme";
            this.BtnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnEscolher
            // 
            this.BtnEscolher.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEscolher.FlatAppearance.BorderSize = 0;
            this.BtnEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEscolher.ForeColor = System.Drawing.Color.Black;
            this.BtnEscolher.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.BtnEscolher.IconColor = System.Drawing.Color.Black;
            this.BtnEscolher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEscolher.IconSize = 30;
            this.BtnEscolher.Location = new System.Drawing.Point(0, 100);
            this.BtnEscolher.Name = "BtnEscolher";
            this.BtnEscolher.Size = new System.Drawing.Size(171, 47);
            this.BtnEscolher.TabIndex = 1;
            this.BtnEscolher.Text = "Escolher Filme";
            this.BtnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEscolher.UseVisualStyleBackColor = true;
            this.BtnEscolher.Click += new System.EventHandler(this.BtnEscolher_Click);
            // 
            // panelLatSuperior
            // 
            this.panelLatSuperior.Controls.Add(this.pictureBox1);
            this.panelLatSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLatSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelLatSuperior.Name = "panelLatSuperior";
            this.panelLatSuperior.Size = new System.Drawing.Size(171, 100);
            this.panelLatSuperior.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OQueAssistir.Properties.Resources.kisspng_film_screening_night_cinema_child_movie_5abbd494b40fe5_3930240615222590927375;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtFechar
            // 
            this.BtFechar.FlatAppearance.BorderSize = 0;
            this.BtFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtFechar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtFechar.IconColor = System.Drawing.Color.Black;
            this.BtFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtFechar.IconSize = 20;
            this.BtFechar.Location = new System.Drawing.Point(843, 12);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(31, 23);
            this.BtFechar.TabIndex = 3;
            this.BtFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtFechar.UseVisualStyleBackColor = true;
            this.BtFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // Menu_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 571);
            this.Controls.Add(this.panelCentral);
            this.Name = "Menu_Inicial";
            this.Text = "Menu_Inicial";
            this.panelCentral.ResumeLayout(false);
            this.BtMinimizar.ResumeLayout(false);
            this.BtMinimizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconeFormAtual)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLatSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelLateral;
        private FontAwesome.Sharp.IconButton BtnInserir;
        private FontAwesome.Sharp.IconButton BtnEscolher;
        private System.Windows.Forms.Panel panelLatSuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox IconeFormAtual;
        private System.Windows.Forms.Label lblTituloFormFilho;
        private System.Windows.Forms.Panel BtMinimizar;
        private FontAwesome.Sharp.IconButton BtSair;
        private FontAwesome.Sharp.IconButton BtListarFilmes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtFechar;
    }
}