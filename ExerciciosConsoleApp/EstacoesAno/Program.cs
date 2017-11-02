using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacoesAno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para mostrar estações do ano");
            Console.WriteLine("Insira um mês do ano!");
            int mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Verão");
                    break;
                case 2:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Verão");
                    break;
                case 3:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Verão (a partir do dia 20 de março será Outono)");
                    break;
                case 4:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Outono");
                    break;
                case 5:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Outono ");
                    break;
                case 6:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Outono (a partir do dia 21 de junho será Inverno)");
                    break;
                case 7:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Inverno");
                    break;
                case 8:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Inverno");
                    break;
                case 9:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Inverno (a partir do dia 22 de setembro será Primavera)");
                    break;
                case 10:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Primavera ");
                    break;
                case 11:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Primavera ");
                    break;
                case 12:
                    Console.WriteLine("O mês " + mes + " é correspondente á estação: Primavera (a partir do dia 21 de dezembro será Verão");
                    break;
                default:
                    Console.WriteLine("Erro mês ou valor inválido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
