using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTroco
{
    public class MoedaQuantidade
    {
        public string Nome { get; }
        public int Quantidade { get; set; }

        public MoedaQuantidade(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }
    }
}
