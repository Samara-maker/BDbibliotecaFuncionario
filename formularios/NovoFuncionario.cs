using BDtrabalhoFuncionario.DAO;
using BDtrabalhoFuncionario.mapeamento;
using System;
using System.Windows.Forms;

namespace BDtrabalhoFuncionario.formularios
{
    public partial class NovoFuncionario : Form
    {
        private Funcionario funcionarioEditando;

        public NovoFuncionario()
        {
            InitializeComponent();
            this.Load += NovoFuncionario_Load;
        }

        public NovoFuncionario(Funcionario f) : this()
        {
            funcionarioEditando = f;
            id_func.Text = f.id_func.ToString();
            tbNome.Text = f.nome;
            cbSexo.Text = f.sexo;
            tbCpf.Text = f.cpf;
            tbTelefone.Text = f.telefone;
            tbemail.Text = f.email;
            cbCargo.Text = f.cargo;
            dtDataNasc.Value = f.dataNasc.ToDateTime(new TimeOnly(0, 0));
            dtAdmissao.Value = f.dataAdmissao.ToDateTime(new TimeOnly(0, 0));
            dataDemissao.Enabled = true;
            dataDemissao.Text = f.dataDemissao ?? "";
        }

        private void NovoFuncionario_Load(object sender, EventArgs e)
        {
            cbSexo.Items.AddRange(new string[] { "Masculino", "Feminino", "Outro" });
            cbCargo.Items.AddRange(new string[] { "Auxiliar", "Analista", "Gerente", "Diretor" });

            if (funcionarioEditando == null)
                dataDemissao.Enabled = false;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario
                {
                    nome = tbNome.Text,
                    sexo = cbSexo.Text,
                    dataNasc = DateOnly.FromDateTime(dtDataNasc.Value),
                    cpf = tbCpf.Text,
                    telefone = tbTelefone.Text,
                    email = tbemail.Text,
                    cargo = cbCargo.Text,
                    dataAdmissao = DateOnly.FromDateTime(dtAdmissao.Value),
                    dataDemissao = dataDemissao.Text,
                };

                FuncionarioDAO dao = new FuncionarioDAO();

                if (funcionarioEditando != null)
                {
                    funcionario.id_func = funcionarioEditando.id_func;
                    dao.Alterar(funcionario);
                    MessageBox.Show("Funcionário atualizado com sucesso!");
                }
                else
                {
                    int idGerado = dao.Cadastrar(funcionario);
                    id_func.Text = idGerado.ToString();  // Mostra ID no campo Código
                    id_func.Enabled = false;

                    MessageBox.Show("Funcionário cadastrado com sucesso! ID gerado: " + idGerado);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }


        private void NovoFuncionario_Load_1(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja cancelar? As alterações serão perdidas.","Confirmar Cancelamento", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
