using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Medico : IDadosBasicos
    {
        private List<Especialidade> _especialidades = new List<Especialidade>();

        public IEnumerable<Especialidade> Especialidades { get { return _especialidades; } }

        public int _crm { get; }

        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public int Idade { get; set; }
        
        public Medico(int crm, IDadosBasicos dadosBasicos, Especialidade especialidade)
        {
            _crm = crm;
            Nome = dadosBasicos.Nome;
            DataDeNascimento = dadosBasicos.DataDeNascimento;
            Endereco = dadosBasicos.Endereco;
            Idade = dadosBasicos.Idade;
            _especialidades.Add(especialidade);
        }


    }
}
