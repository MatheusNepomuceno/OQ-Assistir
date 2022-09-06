using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OQueAssistir
{
    class BDbase
    {
        BD Banco = new BD();

        public struct DadosFilme
        {
            public string NomeFilme;
            public string Genero;
            public string Sinopse;
            public string Assistido;
        }
       
        public void Incluir_Filme (string NomeFilme, string Genero, string Sinopse)
        {
            string Query = "INSERT INTO ListaFilmes (NomeFilme,Genero,Sinopse) VALUES('" + NomeFilme + "','" + Genero + "','" + Sinopse+ "')";
            SqlCommand comando = new SqlCommand(Query);
            comando.Connection = Banco.Conectar();
            comando.ExecuteNonQuery();
            Banco.Desconectar();

        }


        public DadosFilme BuscarFilme (string NomeFilme)
        {
            Banco.Desconectar();
               
            SqlCommand comando = new SqlCommand("SELECT NomeFilme, Genero, Sinopse, Assistido from ListaFilmes WHERE NomeFilme ='"+NomeFilme+"'") ;

            comando.Connection = Banco.Conectar();
            

            SqlDataReader sqlDataReader;
            sqlDataReader = comando.ExecuteReader();
            sqlDataReader.Read();

            var DadosFilme = new DadosFilme
            {
                NomeFilme = sqlDataReader.GetString(0),
                Genero = sqlDataReader.GetString(1),
                Sinopse = sqlDataReader.GetString(2),
                Assistido = sqlDataReader.GetString(3)
            };


            Banco.Desconectar();

            return DadosFilme;

        }

        public DadosFilme BuscarPorGenero (string Genero)
        {
            Banco.Desconectar();

            SqlCommand comando = new SqlCommand("select top 1 NomeFilme, Genero, Sinopse, Assistido from ListaFilmes where Genero ='"+Genero+ "'and Assistido = 'Não' order by NEWID()");

            comando.Connection = Banco.Conectar();
            
            SqlDataReader sqlDataReader;
            sqlDataReader = comando.ExecuteReader();
            sqlDataReader.Read();

            var DadosFilme = new DadosFilme
            {
                NomeFilme = sqlDataReader.GetString(0),
                Genero = sqlDataReader.GetString(1),
                Sinopse = sqlDataReader.GetString(2),
                Assistido = sqlDataReader.GetString(3)
            };


            Banco.Desconectar();

            return DadosFilme;
        }
        
        public void AlterarFilmeAssistido(string NomeFilme)
        {
            string Assistido = "Sim";
            string Query = "update ListaFilmes set Assistido='"+Assistido+"' where NomeFilme='"+NomeFilme+"'";
            SqlCommand comando = new SqlCommand(Query);
            comando.Connection = Banco.Conectar();
            SqlDataReader Leitura;
            Leitura= comando.ExecuteReader();
            Banco.Desconectar();
        }
    }
}
