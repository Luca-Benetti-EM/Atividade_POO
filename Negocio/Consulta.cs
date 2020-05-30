using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Consulta
    {
        public DateTime _dataDaConsulta { get; set; }

        public Medico _medico { get; }

        public Paciente _paciente { get; }

        public Consulta (Paciente paciente, Medico medico, DateTime dataDaConsulta)
        {
            _medico = medico;
            _paciente = paciente;
            _dataDaConsulta = dataDaConsulta;
        }

        
    }
}
