using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace OQueAssistir
{
    public partial class FormInicio : Form
    {
        
        public FormInicio()
        {
            InitializeComponent();
            LblResultadoJogo.Visible = false;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Jogar_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            int ParouImpar = randNum.Next(50);
            txtResultado.Text = ParouImpar.ToString();

            if (ParouImpar % 2 == 0)
            {
                LblResultadoJogo.Visible = true;
                LblResultadoJogo.Text = "O número é par";
            }
            else
            {
                LblResultadoJogo.Visible = true;
                LblResultadoJogo.Text = "O número é impar";
            }


        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_Inicial menu_Inicial = new Menu_Inicial();

            menu_Inicial.Show();
            
        }

        private void FormInicio_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

