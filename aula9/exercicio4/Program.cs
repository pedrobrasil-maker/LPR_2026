using System;
using System.Collections.Generic;

struct Piloto
{
    public string Nome;
    public string Equipe;
    public int Pontuacao;
}

class Program
{
    static List<Piloto> pilotos = new List<Piloto>();

    static void CadastrarPiloto()
    {
        for (int i = 0; i < 10; i++)
        {
            Piloto p;

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Equipe: ");
            p.Equipe = Console.ReadLine();

            Console.Write("Pontuação: ");
            p.Pontuacao = int.Parse(Console.ReadLine());

            pilotos.Add(p);
            Console.WriteLine();
        }
    }

    static void ExibirRanking()
    {
      
        for (int i = 0; i < pilotos.Count - 1; i++)
        {
            int maior = i;

            for (int j = i + 1; j < pilotos.Count; j++)
            {
                if (pilotos[j].Pontuacao > pilotos[maior].Pontuacao)
                    maior = j;
            }

            Piloto aux = pilotos[i];
            pilotos[i] = pilotos[maior];
            pilotos[maior] = aux;
        }

        Console.WriteLine("\nRANKING");

        for (int i = 0; i < pilotos.Count; i++)
        {
            Console.WriteLine((i + 1) + "º - " +
                pilotos[i].Nome + " | " +
                pilotos[i].Equipe + " | " +
                pilotos[i].Pontuacao + " pontos");
        }
    }

    static double CalcularPontuacaoMedia()
    {
        int soma = 0;

        foreach (Piloto p in pilotos)
            soma += p.Pontuacao;

        return (double)soma / pilotos.Count;
    }

    static void ExibirMelhorEquipe()
    {
        string melhorEquipe = "";
        int maiorSoma = -1;

        for (int i = 0; i < pilotos.Count; i++)
        {
            string equipe = pilotos[i].Equipe;
            int soma = 0;

       
            for (int j = 0; j < pilotos.Count; j++)
            {
                if (pilotos[j].Equipe == equipe)
                    soma += pilotos[j].Pontuacao;
            }

            if (soma > maiorSoma)
            {
                maiorSoma = soma;
                melhorEquipe = equipe;
            }
        }

        Console.WriteLine("\nMelhor equipe: " + melhorEquipe);
        Console.WriteLine("Total de pontos: " + maiorSoma);
    }

    static void Main()
    {
        CadastrarPiloto();

        ExibirRanking();

        double media = CalcularPontuacaoMedia();

        Console.WriteLine("\nMédia de pontos: " + media);

        int acima = 0;

        foreach (Piloto p in pilotos)
        {
            if (p.Pontuacao > media)
                acima++;
        }

        Console.WriteLine("Pilotos acima da média: " + acima);

        ExibirMelhorEquipe();
    }
}