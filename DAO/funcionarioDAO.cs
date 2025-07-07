using BDtrabalhoFuncionario.mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDtrabalhoFuncionario.mapeamento;
using MySql.Data.MySqlClient;
using BDtrabalhoFuncionario.conexao;

namespace BDtrabalhoFuncionario.DAO
{
    internal class FuncionarioDAO
    {
        public void Cadastrar(Funcionario f)
        {
            try
            {
                string sql = "INSERT INTO funcionario(nome, sexo, dataNasc, cpf, telefone, email, cargo, dataAdmissao, dataDemissao) " +
                             "VALUES (@nome, @sexo, @dataNasc, @cpf, @telefone, @email, @cargo, @dataAdmissao, @dataDemissao)";

                var cmd = new MySqlCommand(sql, Conexao.Conectar());

                cmd.Parameters.AddWithValue("@nome", f.nome);
                cmd.Parameters.AddWithValue("@sexo", f.sexo);
                cmd.Parameters.AddWithValue("@dataNasc", f.dataNasc.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@cpf", f.cpf);
                cmd.Parameters.AddWithValue("@telefone", f.telefone);
                cmd.Parameters.AddWithValue("@email", f.email);
                cmd.Parameters.AddWithValue("@cargo", f.cargo);
                cmd.Parameters.AddWithValue("@dataAdmissao", f.dataAdmissao.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@dataDemissao", f.dataDemissao.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar funcionário: " + ex.Message);
            }
        }

        public void Alterar(Funcionario f)
        {
            try
            {
                string sql = "UPDATE funcionario SET nome=@nome, sexo=@sexo, DataNascimento=@DataNascimento, CPF=@CPF, telefone=@telefone, email=@email, cargo=@cargo, DataAdmissao=@DataAdmissao, DataDemissao=@DataDemissao WHERE id=@id";

                var cmd = new MySqlCommand(sql, Conexao.Conectar());

                cmd.Parameters.AddWithValue("@nome", f.nome);
                cmd.Parameters.AddWithValue("@sexo", f.sexo);
                cmd.Parameters.AddWithValue("@dataNasc", f.dataNasc.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@cpf", f.cpf);
                cmd.Parameters.AddWithValue("@telefone", f.telefone);
                cmd.Parameters.AddWithValue("@email", f.email);
                cmd.Parameters.AddWithValue("@cargo", f.cargo);
                cmd.Parameters.AddWithValue("@dataAdmissao", f.dataAdmissao.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@DataDemissao", f.dataDemissao.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@id", f.id_func);

                cmd.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar funcionário: " + ex.Message);
            }
        }

        public void Deletar(Funcionario f)
        {
            try
            {
                string sql = "DELETE FROM funcionario WHERE id=@id";

                var cmd = new MySqlCommand(sql, Conexao.Conectar());
                cmd.Parameters.AddWithValue("@id", f.id_func);

                cmd.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar funcionário: " + ex.Message);
            }
        }

        public List<Funcionario> BuscarTodos()
        {
            List<Funcionario> lista = new List<Funcionario>();

            try
            {
                string sql = "SELECT * FROM funcionario ORDER BY nome";
                var cmd = new MySqlCommand(sql, Conexao.Conectar());

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Funcionario f = new Funcionario();
                        f.id_func = dr.GetInt32("id_func");
                        f.nome = dr.GetString("nome");
                        f.sexo = dr.GetString("sexo");
                        f.dataNasc = DateOnly.FromDateTime(dr.GetDateTime("dataNasc"));
                        f.cpf = dr.GetString("cpf");
                        f.telefone = dr.GetString("telefone");
                        f.email = dr.GetString("email");
                        f.cargo = dr.GetString("cargo");
                        f.dataAdmissao = DateOnly.FromDateTime(dr.GetDateTime("dataAdmissao"));
                        f.dataDemissao = DateOnly.FromDateTime(dr.GetDateTime("dataDemissao"));

                        lista.Add(f);
                    }
                }

                Conexao.FecharConexao();
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar funcionários: " + ex.Message);
            }
        }
    }
}
