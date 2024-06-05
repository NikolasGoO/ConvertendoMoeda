using ConvertendoMoeda.Classes;
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Moeda moeda = new Moeda();

        Console.WriteLine("Digite um valor em Real para Conversão:");
        var brlValue = Convert.ToDecimal(Console.ReadLine());
        moeda.SetValue(brlValue);

        Console.WriteLine($"Deseja converter o valor de R$ {moeda.Value}:\n\n1.Dólar\n2.Euro\n3.Iene\n4.Libra esterlina");
        var response = Convert.ToInt32(Console.ReadLine());

        switch(response)
        {
            case 1:
                moeda.RealParaDolar(brlValue);
                break;
            case 2:
                moeda.RealParaEuro(brlValue);
                break;
            case 3:
                moeda.RealParaIene(brlValue);
                break;
            case 4:
                moeda.RealParaLibraEsterlina(brlValue);
                break;
            default:
                Console.WriteLine("Inválido!!! Selecione Novamente");
                break;
        }
    }
}
