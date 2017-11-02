using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa Par ou impar
            Console.WriteLine("Insira um número");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número " + num + " é par!");
            }
            else
            {
                Console.WriteLine("O número " + num + " é impar!");
            }
            Console.ReadKey();
        }
    }
}
