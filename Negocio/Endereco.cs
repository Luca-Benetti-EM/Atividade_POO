using System;


namespace Negocio
{
    public class Endereco
    {
        public string Logradouro;
        public int Numero;
        public string Bairro;
        public string CEP;

        public Endereco(string logradouro, int numero, string bairro, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
        }
    }
}
