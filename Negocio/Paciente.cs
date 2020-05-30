using System;

namespace Negocio
{
    public class Paciente : IDadosBasicos
    {

        public Plano Plano { get; }

        public string _cpf;

        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public int Idade { get; set; }

        public Paciente(string cpf, IDadosBasicos dadosBasicos, Plano plano)
        {
            _cpf = cpf;
            Nome = dadosBasicos.Nome;
            DataDeNascimento = dadosBasicos.DataDeNascimento;
            Endereco = dadosBasicos.Endereco;
            Idade = dadosBasicos.Idade;
            Plano = plano;
        }
    }
}
