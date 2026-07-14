
using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        int soma = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Digite o valor da posição [" + i + "," + j + "]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
                soma += matriz[i, j];
            }
        }

        Console.WriteLine("\nMatriz:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSoma dos elementos: " + soma);
    }
}


