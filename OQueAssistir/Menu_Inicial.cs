using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace OQueAssistir
{
    public partial class Menu_Inicial : Form
    {

        private IconButton BotaoAtual;
        private Panel BordaEsquerdaBtn;
        private Form formFilhoAtual;



        public Menu_Inicial()
        {
            InitializeComponent();

            BordaEsquerdaBtn = new Panel();
            BordaEsquerdaBtn.Size = new Size(7,60);
            panelLateral.Controls.Add(BordaEsquerdaBtn);

            //Formulário
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }

        private void AtivarButao(object EnviarBtn)
        {
            if (EnviarBtn != null)
            {
                DesativarBotao();

                BotaoAtual = (IconButton)EnviarBtn;
                BotaoAtual.BackColor = Color.FromArgb(173, 216, 230);
                BotaoAtual.TextAlign = ContentAlignment.MiddleCenter;
                BotaoAtual.TextImageRelation = TextImageRelation.TextBeforeImage;
                BotaoAtual.ImageAlign = ContentAlignment.MiddleRight;

                //Borda Esquerda do Botao

                BordaEsquerdaBtn.Location = new Point(0, BotaoAtual.Location.Y);
                BordaEsquerdaBtn.Visible = true;
                BordaEsquerdaBtn.BringToFront();

                //Icone do formulário atual
                IconeFormAtual.IconChar = BotaoAtual.IconChar;


            }
        }

        private void DesativarBotao()
        {
            if (BotaoAtual != null)
            {
               
                BotaoAtual.BackColor = Color.FromArgb(32, 178, 170);
                BotaoAtual.TextAlign = ContentAlignment.MiddleCenter;
                BotaoAtual.TextImageRelation = TextImageRelation.ImageBeforeText;
                BotaoAtual.ImageAlign = ContentAlignment.MiddleCenter;

                //Borda Esquerda do Botao

                BordaEsquerdaBtn.Location = new Point(0, BotaoAtual.Location.Y);
                BordaEsquerdaBtn.Visible = true;
                BordaEsquerdaBtn.BringToFront();


            }
        }

        private void AbrirFormFilho(Form FormFilho)
        {
            if (formFilhoAtual != null)
            {
                //Abre apenas um formulário
                formFilhoAtual.Close();
            }

            formFilhoAtual = FormFilho;
            FormFilho.TopLevel = false;
            FormFilho.FormBorderStyle = FormBorderStyle.None;
            FormFilho.Dock = DockStyle.Fill;
            BtMinimizar.Controls.Add(FormFilho);
            BtMinimizar.Tag = FormFilho;
            FormFilho.BringToFront();
            FormFilho.Show();
            lblTituloFormFilho.Text = FormFilho.Text;

        }

        private void BtSair_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void BtnEscolher_Click(object sender, EventArgs e)
        {
            AtivarButao(sender);
            AbrirFormFilho(new Escolher_Filme());
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            AtivarButao(sender);
            AbrirFormFilho(new Incluir_Filme() );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReiniciarBotao();
            formFilhoAtual.Close();
            lblTituloFormFilho.Text = "Inicio";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

     

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ReiniciarBotao()
        {
            DesativarBotao();
            BordaEsquerdaBtn.Visible = false;
            IconeFormAtual.IconChar = IconChar.Home;

        }

        private void BtListarFilmes_Click(object sender, EventArgs e)
        {
            AtivarButao(sender);
            AbrirFormFilho(new Lista_Filmes());
        }

        private void BtSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
