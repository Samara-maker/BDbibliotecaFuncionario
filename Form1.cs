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
    }
}
