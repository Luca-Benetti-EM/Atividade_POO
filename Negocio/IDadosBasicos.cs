﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IDadosBasicos
    {
        string Nome { get; set; }
        DateTime DataDeNascimento { get; set; }

        Endereco Endereco { get; set; }

        int Idade { get; set; }

    }
}
