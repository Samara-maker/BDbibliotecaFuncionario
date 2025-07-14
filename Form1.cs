using BDtrabalhoFuncionario.DAO;
using BDtrabalhoFuncionario.formularios;
using BDtrabalhoFuncionario.mapeamento;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BDtrabalhoAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            dgvFuncionario.AutoGenerateColumns = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvFuncionario.AutoGenerateColumns = true;
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            try
            {
                List<Funcionario> lista = new FuncionarioDAO().BuscarTodos();
                dgvFuncionario.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var novoFuncionario = new NovoFuncionario())
            {
                if (novoFuncionario.ShowDialog() == DialogResult.OK)
                {
                    AtualizarTabela(); // atualiza após cadastro
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvFuncionario.CurrentRow != null)
            {
                Funcionario f = (Funcionario)dgvFuncionario.CurrentRow.DataBoundItem;
                var form = new NovoFuncionario(f);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    AtualizarTabela(); // atualiza depois da edição
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para editar.");
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (dgvFuncionario.CurrentRow != null)
            {
                Funcionario f = (Funcionario)dgvFuncionario.CurrentRow.DataBoundItem;
                var confirm = MessageBox.Show($"Tem certeza que deseja deletar {f.nome}?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    new FuncionarioDAO().Deletar(f);
                    AtualizarTabela(); // atualiza depois do delete
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para deletar.");
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ESTE CODIGO ABAIXO ESTÁ FILTRANDO O ID, NOME E CPF, PARA QUE A PESSOA POSSA PROCURAR MELHOR O FUNCIONARIO
        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string campo = "";
            string valor = txtPesquisar.Text.Trim();

            if (string.IsNullOrEmpty(cbFiltro.Text) || string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Selecione um filtro e insira um valor para pesquisar.");
                return;
            }

            switch (cbFiltro.Text)
            {
                case "Código":
                    campo = "id_func";
                    break;
                case "Nome":
                    campo = "nome";
                    break;
                case "CPF":
                    campo = "cpf";
                    break;
            }

            try
            {
                dgvFuncionario.DataSource = new FuncionarioDAO().BuscarPorFiltro(campo, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            cbFiltro.SelectedIndex = 0;
            txtPesquisar.Clear();
            AtualizarTabela();
        }
    }
}

