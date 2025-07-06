using BDtrabalhoFuncionario.formularios;

namespace BDtrabalhoAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoFuncionario novoFuncionario = new NovoFuncionario();
            novoFuncionario.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
