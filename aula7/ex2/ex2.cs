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

        Console.WriteLine("\nDigite um número para pesquisar no vetor:");

        int numeroPesquisa;
        while (!int.TryParse(Console.ReadLine(), out numeroPesquisa))
        {
            Console.Write("Valor inválido. Digite um número inteiro: ");
        }

        int contadorOcorrencias = 0;
        string posicoesEncontradas = "";

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == numeroPesquisa)
            {
                contadorOcorrencias++;
                posicoesEncontradas += i + " ";
            }
        }

        if (contadorOcorrencias > 0)
        {
            Console.WriteLine($"\nO número {numeroPesquisa} foi encontrado {contadorOcorrencias} vez(es).");
            Console.WriteLine($"Apareceu na(s) posição(ões): {posicoesEncontradas}");
        }
        else
        {
            Console.WriteLine($"\nO número {numeroPesquisa} não foi encontrado no vetor.");
        }
    }
}