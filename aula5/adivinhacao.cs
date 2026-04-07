

using System;

class Program
{
    static void Main()
    {
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 101); // 1 a 100
        int chute;
        int tentativas = 0;

        do
        {
            Console.Write("Digite um número entre 1 e 100: ");
            chute = int.Parse(Console.ReadLine());
            tentativas++;

            if (chute > valorInteiro)
            {
                Console.WriteLine("Chutou alto!");
            }
            else if (chute < valorInteiro)
            {
                Console.WriteLine("Chutou baixo!");
            }
            else
            {
                Console.WriteLine("Acertou!");
            }

        } while (chute != valorInteiro);

        Console.WriteLine("Você acertou em " + tentativas + " tentativas!");
    }
}