using System;

struct Heroi
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}

struct Equipe
{
    public Heroi[] Herois;
}

class Program
{
    static Heroi[] herois = new Heroi[5];
    static int qtdHerois = 0;

    static Equipe equipe = new Equipe
    {
        Herois = new Heroi[3]
    };

    static void Main()
    {
        menuPrincipal();
    }

    static void menuPrincipal()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi();
                    break;

                case 2:
                    selecionarEquipe();
                    break;

                case 3:
                    exibirEquipe();
                    break;
            }

        } while (opcao != 4);
    }

    static void cadastrarHeroi()
    {
        if (qtdHerois >= 5)
        {
            Console.WriteLine("Limite de heróis atingido.");
            return;
        }

        Console.Write("Nome: ");
        herois[qtdHerois].Nome = Console.ReadLine();

        Console.Write("Poder: ");
        herois[qtdHerois].Poder = Console.ReadLine();

        Console.Write("Pontuação: ");
        herois[qtdHerois].Pontuacao = int.Parse(Console.ReadLine());

        qtdHerois++;
    }

    static void selecionarEquipe()
    {
        if (qtdHerois < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis.");
            return;
        }

        Console.WriteLine("\nHeróis cadastrados:");

        for (int i = 0; i < qtdHerois; i++)
        {
            Console.WriteLine($"{i + 1} - {herois[i].Nome}");
        }

        for (int i = 0; i < 3; i++)
        {
            int escolha;

            do
            {
                Console.Write($"Escolha o herói {i + 1}: ");
                escolha = int.Parse(Console.ReadLine());
            }
            while (escolha < 1 || escolha > qtdHerois);

            equipe.Herois[i] = herois[escolha - 1];
        }
    }

    static int calcularPontuacaoTotal()
    {
        int soma = 0;

        for (int i = 0; i < 3; i++)
        {
            soma += equipe.Herois[i].Pontuacao;
        }

        return soma;
    }

    static void exibirEquipe()
    {
        if (string.IsNullOrEmpty(equipe.Herois[0].Nome))
        {
            Console.WriteLine("Nenhuma equipe foi selecionada.");
            return;
        }

        Console.WriteLine("\n=== EQUIPE ===");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(
                $"{equipe.Herois[i].Nome} - " +
                $"{equipe.Herois[i].Poder} - " +
                $"{equipe.Herois[i].Pontuacao} pontos");
        }

        Console.WriteLine($"Pontuação Total: {calcularPontuacaoTotal()}");
    }
}