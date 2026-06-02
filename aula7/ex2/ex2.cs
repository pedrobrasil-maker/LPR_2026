
using System;

class Program
{
    public static void Main(string[] args)
    {
    
        int[] vetor = new int[10];
        
        
        Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Posição [{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine("\nDigite um número para pesquisar no vetor:");
        int numeroPesquisa = int.Parse(Console.ReadLine());

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
            Console.WriteLine($"O número {numeroPesquisa} foi encontrado {contadorOcorrencias} vez(es).");
            Console.WriteLine($"Apareceu na(s) posição(ões): {posicoesEncontradas}");
        }
        else
        {
            Console.WriteLine($"O número {numeroPesquisa} não foi encontrado no vetor.");
        }
    }
}