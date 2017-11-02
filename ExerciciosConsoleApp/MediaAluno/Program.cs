using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, media;

            nota1 = valida("Insira a primeira nota: ");

            nota2 = valida("Insira a segunda nota: ");

            media = (nota1 + nota2) / 2;

            Console.WriteLine("A Média do aluno foi: " + media);

            float valida(string mensagem)
            {
                float retorno = 0;
                do
                {
                    Console.Write(mensagem);
                    string dado = Console.ReadLine();

                    try //Lança a exceção
                    {
                        retorno = Convert.ToSingle(dado);
                    }
                    catch (Exception) //Captura a exceção
                    {
                        //Trata a exceção
                        Console.WriteLine("Valor inválido, entre com um número inteiro");
                    }
                }
                while (retorno == 0);
                return retorno;
                //Console.WriteLine("Fim do programa!"); //A execução continua após o bloco catch
            }
            Console.ReadKey();
        }
    }
    
}
