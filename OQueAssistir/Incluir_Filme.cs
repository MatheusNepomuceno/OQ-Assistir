using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OQueAssistir
{
    public partial class Incluir_Filme : Form
    {
        
        public Incluir_Filme()
        {
            InitializeComponent();

            textBoxSinopse.Visible = false;
           
        }

        private void checkBoxSinopse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSinopse.Checked == true)
            {
                textBoxSinopse.Visible = true;
            }
            if (checkBoxSinopse.Checked == false)
            {
                textBoxSinopse.Visible = false;
            }
        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {
           // string Query = "INSERT INTO catalago (NomeFilme,Genero,Sinopse) VALUES('"+txtNomeFilme.Text+"','"+cbGenero.Text+"','"+textBoxSinopse.Text+"')";
            BDbase dbase = new BDbase();

            try
            {
                dbase.Incluir_Filme(txtNomeFilme.Text,cbGenero.Text,textBoxSinopse.Text);
                MessageBox.Show(txtNomeFilme.Text + " inserido com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir", erro.Message);
            }

            

            txtNomeFilme.Text = string.Empty;
            cbGenero.Text = string.Empty;
            textBoxSinopse.Text = string.Empty;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
