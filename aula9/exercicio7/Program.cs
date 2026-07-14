using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> cidades = new Dictionary<string, int>();

        Console.Write("Quantidade de cidades: ");
        int x = int.Parse(Console.ReadLine());

     
        for (int i = 0; i < x; i++)
        {
            Console.Write("\nNome da cidade: ");
            string nome = Console.ReadLine();

            Console.Write("População: ");
            int populacao = int.Parse(Console.ReadLine());

            cidades[nome] = populacao;
        }

        
        int soma = 0;

        foreach (KeyValuePair<string, int> cidade in cidades)
        {
            soma += cidade.Value;
        }

        double media = (double)soma / cidades.Count;

        Console.WriteLine("\nMédia da população: " + media);

        
        Console.WriteLine("\nCidades acima da média:");

        foreach (KeyValuePair<string, int> cidade in cidades)
        {
            if (cidade.Value > media)
            {
                Console.WriteLine(cidade.Key + " - " + cidade.Value + " habitantes");
            }
        }

        string maisPopulosa = "";
        string menosPopulosa = "";

        int maior = int.MinValue;
        int menor = int.MaxValue;

        foreach (KeyValuePair<string, int> cidade in cidades)
        {
            if (cidade.Value > maior)
            {
                maior = cidade.Value;
                maisPopulosa = cidade.Key;
            }

            if (cidade.Value < menor)
            {
                menor = cidade.Value;
                menosPopulosa = cidade.Key;
            }
        }

        Console.WriteLine("\nCidade mais populosa: " 
            + maisPopulosa + " - " + maior + " habitantes");

        Console.WriteLine("Cidade menos populosa: "
            + menosPopulosa + " - " + menor + " habitantes");


     
        Console.Write("\nDigite a população que deseja remover: ");
        int y = int.Parse(Console.ReadLine());

        List<string> remover = new List<string>();

        foreach (KeyValuePair<string, int> cidade in cidades)
        {
            if (cidade.Value == y)
            {
                remover.Add(cidade.Key);
            }
        }

        foreach (string nome in remover)
        {
            cidades.Remove(nome);
        }


        
        Console.WriteLine("\nDicionário atualizado:");

        foreach (KeyValuePair<string, int> cidade in cidades)
        {
            Console.WriteLine(cidade.Key + " -> "
                + cidade.Value + " habitantes");
        }
    }
}
