using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Posição [{i}]: ");

            while (!int.TryParse(Console.ReadLine(), out vetor[i]))
            {
                Console.Write("Valor inválido. Digite um número inteiro: ");
            }
        }

        Console.Write("\nDigite o número que deseja pesquisar: ");

        int numeroPesquisa;
        while (!int.TryParse(Console.ReadLine(), out numeroPesquisa))
        {
            Console.Write("Valor inválido. Digite um número inteiro: ");
        }

        int ocorrencias = 0;

        Console.WriteLine("\nPosições encontradas:");

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == numeroPesquisa)
            {
                Console.WriteLine($"Posição {i}");
                ocorrencias++;
            }
        }

        if (ocorrencias > 0)
        {
            Console.WriteLine($"\nO número {numeroPesquisa} apareceu {ocorrencias} vez(es).");
        }
        else
        {
            Console.WriteLine($"\nO número {numeroPesquisa} não foi encontrado no vetor.");
        }
    }
}
