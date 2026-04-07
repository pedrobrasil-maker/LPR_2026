using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int quadrado = numero * numero;
        int soma = 0;

        int temp = quadrado;

        while (temp > 0)
        {
            soma += temp % 10; 
            temp /= 10;        
        }

        Console.WriteLine("Quadrado: " + quadrado);
        Console.WriteLine("Soma dos dígitos: " + soma);
    }
}