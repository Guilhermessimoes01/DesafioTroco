using System;
using DesafioTroco;

namespace DesafioTroco
{
        public class Moeda
    {
        public string Nome { get; }
        public int ValorCentavos { get; }

        public Moeda(string nome, int valorCentavos)
        {
            Nome = nome;
            ValorCentavos = valorCentavos;
        }
    }

}
