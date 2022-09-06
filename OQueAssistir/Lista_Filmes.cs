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
    public partial class Lista_Filmes : Form
    {
        public Lista_Filmes()
        {
            InitializeComponent();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            BD banco = new BD();
            string strProvedor = "Data Source=TEC-TINF-TI6;Initial Catalog=Filmes;Integrated Security=True";
            string Query = "select NomeFilme,Genero, Sinopse from ListaFilmes";
            SqlConnection con = new SqlConnection(strProvedor);
            SqlCommand comando = new SqlCommand(Query, con);

            con.Open();

            

            comando.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(comando);

            DataTable dtFIlmes = new DataTable();

            da.Fill(dtFIlmes);

            dgvFilmes.DataSource = dtFIlmes;


            con.Close();

        }
    }
}
