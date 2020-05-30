using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{

    public class Plano
    {
        public TiposDePlano TipoDoPlano { get; set; }
        public string NomeDoPlano { get; set; }

        public Plano(string nomeDoPlano, TiposDePlano tipoDoPlano)
        {
            NomeDoPlano = nomeDoPlano;
            TipoDoPlano = tipoDoPlano;
        }
    }
}
