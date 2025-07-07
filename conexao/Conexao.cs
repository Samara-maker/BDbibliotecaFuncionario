using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BDtrabalhoFuncionario.mapeamento;

namespace BDtrabalhoFuncionario.conexao
{
    internal class Conexao
    {

        public static MySqlConnection conexao;

        public static MySqlConnection Conectar()
        {
            try
            {

                string strconexao = "server=localhost;uid=root;pwd=root;port=3306;database=bdBiblioteca";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
                return conexao;

            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO CONECTAR COM O BANCO DE DADOS" + ex.Message);
            }

        }
        public static void FecharConexao()
        {
            conexao.Close();
        }

    }

}