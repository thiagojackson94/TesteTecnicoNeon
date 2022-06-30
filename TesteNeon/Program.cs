using System;
using System.Collections.Generic;

namespace TesteNeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //bool result = VerificaSeEPalindromo("socorrammesubinoonibusemmarrocos");
            //Console.WriteLine("digite: ");

            //var valor = Console.ReadLine();
            //int posicao = Convert.ToInt32(valor);
            //fibonacci(posicao);
            //Console.WriteLine();

            MaioEMenorElementoLista();

            Console.ReadKey();
        }

        private static void MaioEMenorElementoLista()
        {
            Random random = new Random();

            List<int> listaNumeros = new List<int> { random.Next(), random.Next(), random.Next(), random.Next(), random.Next(), random.Next(), random.Next(), random.Next(), random.Next(), random.Next() };

            int maior = listaNumeros[0], menor = listaNumeros[0];

            for (int i = 0; i < listaNumeros.Count; i++)
            {
                maior = listaNumeros[i] > maior ? listaNumeros[i] : maior;

                menor = listaNumeros[i] < menor? listaNumeros[i] : menor;

            }

            Console.WriteLine($"O maior elemento da lista é: {maior} e o menor elemento da lista é: {menor}");
        }

        private static void fibonacci(int valor)
        {
            int soma = 0, ultimo = 1, penultimo = 1;

            Console.WriteLine($"{penultimo}");
            Console.WriteLine($"{ultimo}");

            for (int i = 1; i < valor; i++)
            {
                soma = ultimo + penultimo;
                penultimo = ultimo;
                ultimo = soma;

                Console.WriteLine($"{soma}");
            }

        }

        private static bool VerificaSeEPalindromo(string palavraEntrada = "")
        {
            string palavraInvertida = "";

            for (int i = palavraEntrada.Length -1; i >=0 ; i--)
            {
                palavraInvertida += palavraEntrada[i];
            }

            if(palavraEntrada == palavraInvertida)
            {
                return true;
            }
            else{
                return false;
            }
        }
    }
}
