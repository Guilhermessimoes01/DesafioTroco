using DesafioTroco;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exemplo sem considerar o estoque de moedas:");
        Console.Write("Digite o custo do produto: ");
        double custoProduto1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor pago pelo usuário: ");
        double valorPago1 = Convert.ToDouble(Console.ReadLine());

        TrocoMachine trocoMachine = new TrocoMachine();
        trocoMachine.CalcularTroco(custoProduto1, valorPago1);

        Console.WriteLine("\nExemplo considerando o estoque de moedas:");
        Console.Write("Digite o estoque de moedas de R$0,50: ");
        int estoqueMoeda50 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o estoque de moedas de R$0,05: ");
        int estoqueMoeda05 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o custo do produto: ");
        double custoProduto2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor pago pelo usuário: ");
        double valorPago2 = Convert.ToDouble(Console.ReadLine());

        TrocoMachineComEstoque trocoMachineComEstoque = new TrocoMachineComEstoque(estoqueMoeda50, estoqueMoeda05);
        trocoMachineComEstoque.CalcularTroco(custoProduto2, valorPago2);
    }
}