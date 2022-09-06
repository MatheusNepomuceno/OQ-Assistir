using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OQueAssistir
{
    class BD
    {
        SqlConnection conexao = new SqlConnection();

        public BD()
        {
           conexao.ConnectionString = "Data Source=TEC-TINF-TI6;Initial Catalog=Filmes;Integrated Security=True";
           
        }

        public SqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        public SqlConnection Desconectar()
        {
            if (conexao.State== System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
            return conexao;
            
        }
    }
}
