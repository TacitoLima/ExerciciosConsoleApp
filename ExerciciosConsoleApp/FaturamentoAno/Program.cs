using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoAno
{
    class Program
    {
        static void Main(string[] args)
        {
                double[] faturamento = new double[12];
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("Insira o faturamento do " + (i + 1) + "º mês");
                    faturamento[i] = Convert.ToDouble(Console.ReadLine());
                }
                foreach (double x in faturamento)
                {
                    int i = 1;
                    Console.WriteLine("O faturamento do mês " + i + 1 + " foi de " + x);
                }
                double total = faturamento.Sum();

                if (total <= 50000)
                {
                    Console.WriteLine("\nO faturamento foi baixo :" + total);
                }
                else if ((total >= 50001) && (total <= 100000))
                {
                    Console.WriteLine("\nO faturamento foi médio :" + total);
                }
                else if (total >= 100001)
                {
                    Console.WriteLine("\nO faturamento foi alto :" + total);
                }

                Console.ReadKey();
            }
    }
}
