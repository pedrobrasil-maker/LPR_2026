
using System;

class Program
{
    static string VerificarAssento(int[,] sala, int linha, int coluna)
    {
        if (sala[linha, coluna] == 0)
            return "Livre";
        else
            return "Ocupado";
    }

    static void MostrarMapa(int[,] sala)
    {
        Console.WriteLine("\nMapa da Sala");

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(sala[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] sala = new int[6, 8];
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Reservar assento");
            Console.WriteLine("2 - Cancelar reserva");
            Console.WriteLine("3 - Consultar assento");
            Console.WriteLine("4 - Mostrar mapa da sala");
            Console.WriteLine("5 - Encerrar");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Linha (0 a 5): ");
                    int linha = int.Parse(Console.ReadLine());

                    Console.Write("Coluna (0 a 7): ");
                    int coluna = int.Parse(Console.ReadLine());

                    if (VerificarAssento(sala, linha, coluna) == "Livre")
                    {
                        sala[linha, coluna] = 1;
                        Console.WriteLine("Reserva realizada.");
                    }
                    else
                    {
                        Console.WriteLine("Assento já está ocupado.");
                    }
                    break;

                case 2:
                    Console.Write("Linha (0 a 5): ");
                    linha = int.Parse(Console.ReadLine());

                    Console.Write("Coluna (0 a 7): ");
                    coluna = int.Parse(Console.ReadLine());

                    if (VerificarAssento(sala, linha, coluna) == "Ocupado")
                    {
                        sala[linha, coluna] = 0;
                        Console.WriteLine("Reserva cancelada.");
                    }
                    else
                    {
                        Console.WriteLine("O assento já está livre.");
                    }
                    break;

                case 3:
                    Console.Write("Linha (0 a 5): ");
                    linha = int.Parse(Console.ReadLine());

                    Console.Write("Coluna (0 a 7): ");
                    coluna = int.Parse(Console.ReadLine());

                    Console.WriteLine("Situação: " + VerificarAssento(sala, linha, coluna));
                    break;

                case 4:
                    MostrarMapa(sala);
                    break;

                case 5:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 5);
    }
}


