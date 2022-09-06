using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OQueAssistir
{
    public partial class Escolher_Filme : Form
    {
        public Escolher_Filme()
        {
            InitializeComponent();
        }

        private void btBuscarNom_Click(object sender, EventArgs e)
        {
 
            
            BDbase dbase = new BDbase();
            
            try
            {

                var RetornoBuscar = dbase.BuscarFilme (txtNomeFilme.Text);
                string Assistido= "Sim";
                txtNomeFilme.Text = RetornoBuscar.NomeFilme;
                cbGenero.Text = RetornoBuscar.Genero;
                txtSinopse.Text = RetornoBuscar.Sinopse;
                if(RetornoBuscar.Assistido == Assistido)
                {
                    MessageBox.Show("Filme já assistido");
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar", erro.Message);
                MessageBox.Show(txtNomeFilme.Text);
            }


        }

        private void btBuscarGen_Click(object sender, EventArgs e)
        {
            BDbase dbase = new BDbase();

            try
            {

                var RetornoBuscar = dbase.BuscarPorGenero(cbGenero.Text);
                string Assistido = "Sim";
                txtNomeFilme.Text = RetornoBuscar.NomeFilme;
                cbGenero.Text = RetornoBuscar.Genero;
                txtSinopse.Text = RetornoBuscar.Sinopse;
                if (RetornoBuscar.Assistido == Assistido)
                {
                    MessageBox.Show("Filme já assistido");
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar", erro.Message);
                MessageBox.Show(cbGenero.Text);
                cbGenero.Text = string.Empty;
                txtSinopse.Text = string.Empty;
                txtNomeFilme.Text = string.Empty;
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAssistir_Click(object sender, EventArgs e)
        {
            BDbase dbase = new BDbase();
            string NomeFilme = txtNomeFilme.Text;
            string target = "www.google.com.br/search?q="+NomeFilme+"";

            try
            {
                dbase.AlterarFilmeAssistido(NomeFilme);
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir", erro.Message);
            }


            
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode== -2147467259)
                {
                    MessageBox.Show(noBrowser.Message);
                }
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }

            
        }
    }
}
