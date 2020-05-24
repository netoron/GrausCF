using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            string divisao;
            double total;
            double mais = 1.8;
            double menos = 32;
            double conteudo;
            
            Console.WriteLine("Digite a temperatura em °C para ser convertido em °F");
            divisao = Console.ReadLine();
            
            conteudo = Convert.ToDouble(divisao);

            total = conteudo * mais + menos;
            
            Console.WriteLine($"Conversão é {total}°F");



        }
    }
}
