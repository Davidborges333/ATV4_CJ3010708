using System.ComponentModel.DataAnnotations;

namespace ATV4_CJ3010708
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha uma variavel");
            Console.WriteLine("Variavel A para Adição");
            Console.WriteLine("Variavel B para Subtração");
            Console.WriteLine("Variavel C para Divisão ");
            Console.WriteLine("variavel D para Multiplicação");
            Console.WriteLine("Digite a variavel que você escolher");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "A":
                    int variave1A = 50;
                    Console.WriteLine("Você escolheu a variavel A. seu valor é:+ variavel1A");
                    break;
                case "B":
                    string variavel1B = "ola, Borges";
                    Console.WriteLine("Você escolheu a variavel B. seu valor é: + variavel1B");
                    break;
                case "C":
                    string variavel1C = "50";
                    Console.WriteLine("você escolheu a variavel C. seu valor é + variavel1C");
                    break;
                case "D":
                    int variavel1D = 50;
                    Console.WriteLine("Voce escolheu a variavel D. seu valor é + variavelD");
                    break;
                default:
                    Console.WriteLine("sua escolha foi invalida");
                    break;

            }

            Console.ReadLine();

            }

        }
    }

