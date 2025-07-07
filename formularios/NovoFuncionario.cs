using BDtrabalhoFuncionario.DAO;
using BDtrabalhoFuncionario.mapeamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDtrabalhoFuncionario.formularios
{
    public partial class NovoFuncionario : Form
    {
        public NovoFuncionario()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();

                funcionario.nome = tbNome.Text;
                funcionario.sexo = cbSexo.Text;
                funcionario.dataNasc = DateOnly.FromDateTime(dtDataNasc.Value);
                funcionario.cpf = tbCpf.Text;
                funcionario.telefone = tbTelefone.Text;
                funcionario.email = tbemail.Text;
                funcionario.cargo = cbCargo.Text;
                funcionario.dataAdmissao = DateOnly.FromDateTime(dtAdmissao.Value);
                funcionario.dataDemissao = DateOnly.FromDateTime(dtDemissao.Value); // pode ser nulo, se quiser

                FuncionarioDAO dao = new FuncionarioDAO();
                dao.Cadastrar(funcionario);

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
