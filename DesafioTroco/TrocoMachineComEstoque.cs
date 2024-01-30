using System;
using DesafioTroco;

namespace DesafioTroco
{
    public class TrocoMachineComEstoque : TrocoMachine
    {
        private int estoqueMoeda50;
        private int estoqueMoeda05;

        public TrocoMachineComEstoque(int estoqueMoeda50, int estoqueMoeda05)
        {
            this.estoqueMoeda50 = estoqueMoeda50;
            this.estoqueMoeda05 = estoqueMoeda05;
        }

        public void CalcularTroco(double custoProduto, double valorPago)
        {
            double troco = valorPago - custoProduto;

            if (troco < 0)
            {
                Console.WriteLine("Valor insuficiente. Faltam: R$" + Math.Abs(troco).ToString("F2"));
                return;
            }

            Console.WriteLine("Troco: R$" + troco.ToString("F2"));

            CalcularMoedas(quantidadeMoedas =>
            {
                if (quantidadeMoedas.Nome == "R$0,50" && quantidadeMoedas.Quantidade > estoqueMoeda50)
                {
                    quantidadeMoedas.Quantidade = estoqueMoeda50;
                }
                else if (quantidadeMoedas.Nome == "R$0,05" && quantidadeMoedas.Quantidade > estoqueMoeda05)
                {
                    quantidadeMoedas.Quantidade = estoqueMoeda05;
                }

                Console.WriteLine($"{quantidadeMoedas.Nome} -> {quantidadeMoedas.Quantidade} moeda(s)");
            }, troco);
        }
    }
}
