using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            float precoCombustivel;
            int consumo;
            float valorGasto;

            Console.WriteLine("Insira a distancia percorrida");
            distancia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o preço do combustível");
            precoCombustivel = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o consumo do carro (km/litro)");
            consumo = Convert.ToInt32(Console.ReadLine());

            distancia = distancia / consumo;

            valorGasto = consumo * precoCombustivel;

            Console.WriteLine("O valor gasto foi: " + valorGasto);
        }
    }
}
