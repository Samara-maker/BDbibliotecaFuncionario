using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDtrabalhoFuncionario.mapeamento
{
    public class Funcionario
    {

        public int id_func { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string cpf { get; set; }
        public string cargo { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public DateOnly dataNasc { get; set; }
        public DateOnly dataAdmissao { get; set; }
        public string dataDemissao { get; set; }



    }
}
