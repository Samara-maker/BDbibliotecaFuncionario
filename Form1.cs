using BDtrabalhoFuncionario.DAO;
using BDtrabalhoFuncionario.formularios;
using BDtrabalhoFuncionario.mapeamento;

namespace BDtrabalhoAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            dataGridView1.AutoGenerateColumns = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoFuncionario novoFuncionario = new NovoFuncionario();
            novoFuncionario.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarTabela()
        {
            try
            {
                List<Funcionario> lista = new FuncionarioDAO().BuscarTodos();
                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarTabela();

        }
    }
}
