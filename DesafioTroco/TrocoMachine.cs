using System;
using DesafioTroco;

namespace DesafioTroco
{
    class TrocoMachine
    {
        protected Moeda[] moedasDisponiveis =
        {
        new Moeda("R$1", 100),
        new Moeda("R$0,50", 50),
        new Moeda("R$0,25", 25),
        new Moeda("R$0,10", 10),
        new Moeda("R$0,05", 5)
    };

        public void CalcularTroco(double custoProduto, double valorPago)
        {
            double troco = valorPago - custoProduto;

            if (troco < 0)
            {
                Console.WriteLine("Valor insuficiente. Faltam: R$" + Math.Abs(troco).ToString("F2"));
                return;
            }

            Console.WriteLine("Troco: R$" + troco.ToString("F2"));

            CalcularMoedas(quantidadeMoedas => Console.WriteLine($"{quantidadeMoedas.Nome} -> {quantidadeMoedas.Quantidade} moeda(s)"), troco);
        }

        protected void CalcularMoedas(Action<MoedaQuantidade> processarMoeda, double troco)
        {
            foreach (var moeda in moedasDisponiveis)
            {
                int quantidadeMoedas = (int)(troco / moeda.ValorCentavos);
                troco %= moeda.ValorCentavos;

                if (quantidadeMoedas > 0)
                {
                    processarMoeda(new MoedaQuantidade(moeda.Nome, quantidadeMoedas));
                }
            }
        }
    }
}
