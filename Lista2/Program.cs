using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Program
    {
        static void Exercicio01()
        {
            
            int Maior = 0, Menor = 0, Soma = 0, Quantidade = 0, Media;

            for (int i = 0; i < 172; ++i)
            {
                Console.Write($"Digite o {i + 1}º valor entre 0 e 23.9568: ");
                int Valor = int.Parse(Console.ReadLine());
                Menor = Valor;
                if (Valor > Maior)
                {
                    Maior = Valor;
                }

                if (Valor < Menor)
                {
                    Menor = Valor;
                }

                if (Valor % 2 == 0 && Valor < 100)
                {
                    Soma += Valor;
                    Quantidade++;
                }
            }

            Console.WriteLine($"\nMaior valor: {Maior}");
            Console.WriteLine($"Menor valor: {Menor}");

            if (Quantidade > 0)
            {
                Media = Soma / Quantidade;
                Console.WriteLine($"Média aritmética dos valores pares menores que 100: {Media}");
            }
        }
        static void Exercicio02()
        {
            int i = 1;
            float Valor, Soma = 0, MediaAritimetica;
            do
            {
                Console.Write($"{i} Valor: ");
                Valor = float.Parse(Console.ReadLine());
                if (Valor >= 0)
                {
                    Soma = Valor + Soma;
                    ++i;
                }
            } while (Valor >= 0);

            Console.WriteLine("Media Aritimérica: {0}", MediaAritimetica = Soma / (i - 1));
            Console.ReadKey();
        }
        static void Exercicio03()
        {
            int X, Y;

            Console.Write("Valor X: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Valor Y: ");
            Y = int.Parse(Console.ReadLine());

            for (int i = X; i <= Y; ++i)
            {
                if (i % 7 == 3 || i % 7 == 5)
                    Console.Write($"{i} ");
            }
            Console.ReadKey();

        }
        static void Exercicio04()
        {
            
            Console.Write("Valor Positivo: ");
            double P = double.Parse(Console.ReadLine());
            double Valor = Math.Pow(P, 3);

            
            for (double i = P; i <= Valor; ++i)
            {
                if (i % 2 == 0)
                    if (i % 4 == 0 && i % 6 != 0)
                        Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
        static void Exercicio05()
        {
            Console.Write("Quantidade de Linhas: ");
            int Linhas = int.Parse(Console.ReadLine());
            Console.Write("Caractere: ");
            char Caractere = char.Parse(Console.ReadLine());

            for (int i = 0; i < Linhas; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write($"{Caractere}");

                }
                Console.WriteLine();
            }
        }
        static void Exercicio06()
        {
            Console.Write("Quantidade de Linhas: ");
            int Linhas = int.Parse(Console.ReadLine());
            Console.Write("Caractere: ");
            char Caractere = char.Parse(Console.ReadLine());

            for (int i = 0; i <= Linhas; ++i)
            {
                for (int j = Linhas; j > i; --j)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; ++j)
                {
                    Console.Write($"{Caractere}");
                }
                for (int j = 0; j < i; ++j)
                {
                    Console.Write($"{Caractere}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar == true)
            {
                Console.Write("\n\n*** MENU ***\n\n");
                Console.Write("Exercicio ente 1 e 6\nPara Sair 0\nEntre uma valor: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Exercicio01();
                        break;

                    case "2":
                        Exercicio02();
                        break;

                    case "3":
                        Exercicio03();
                        break;

                    case "4":
                        Exercicio04();
                        break;

                    case "5":
                        Exercicio05();
                        break;

                    case "6":
                        Exercicio06();
                        break;

                    case "0":
                    default:
                        continuar = false;
                        break;
                }
            }

            Console.WriteLine();
            Console.Write("Tecle para continuar...");
            Console.ReadKey();

        }
    }
}
