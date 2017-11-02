using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do produto?");
            float produto = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Qual a porcentagem de desconto?");
            float desconto = Convert.ToSingle(Console.ReadLine());

            float produtoDescontado = produto * desconto;
            Console.WriteLine("O valor do produto final foi: " + produtoDescontado + " o valor do desconto era " + desconto + " e o valor do produto sem desconto " + produto);
            Console.ReadKey();
        }
    }
}
