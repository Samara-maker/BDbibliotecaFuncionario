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
                if (!ValidarCPF(tbCpf.Text))
                {
                    MessageBox.Show("CPF inválido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

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
            var resultado = MessageBox.Show("Tem certeza que deseja cancelar? As alterações serão perdidas.", "Confirmar Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void tbCpf_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidarCPF(string cpf)
        {
            //verificação passada em sala de aula, tutotial no ava

            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
                return false;

            if (cpf.Distinct().Count() == 1)
                return false;

            // Primeiro dígito
            int soma1 = 0;
            for (int i = 0; i < 9; i++)
                soma1 += (cpf[i] - '0') * (10 - i);

            int resto1 = soma1 % 11;
            int digito1 = resto1 < 2 ? 0 : 11 - resto1;

            if (digito1 != (cpf[9] - '0'))
                return false;

            // Segundo dígito
            int soma2 = 0;
            for (int i = 0; i < 10; i++)
                soma2 += (cpf[i] - '0') * (11 - i);

            int resto2 = soma2 % 11;
            int digito2 = resto2 < 2 ? 0 : 11 - resto2;

            return digito2 == (cpf[10] - '0');
        }

    }
}
