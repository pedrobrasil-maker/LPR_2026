using System;
using System.Collections.Generic;

struct Livro
{
    public string Titulo;
    public string Autor;
    public int Ano;
    public int Quantidade;
}

class Program
{
    static Dictionary<int, Livro> livros = new Dictionary<int, Livro>();

    static void CadastrarLivro()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\nCadastro do livro " + (i + 1));

            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Livro livro;

            Console.Write("Título: ");
            livro.Titulo = Console.ReadLine();

            Console.Write("Autor: ");
            livro.Autor = Console.ReadLine();

            Console.Write("Ano de publicação: ");
            livro.Ano = int.Parse(Console.ReadLine());

            Console.Write("Quantidade disponível: ");
            livro.Quantidade = int.Parse(Console.ReadLine());

            livros[codigo] = livro;
        }
    }


    static void BuscarLivro()
    {
        Console.Write("\nDigite o código do livro: ");
        int codigo = int.Parse(Console.ReadLine());

        if (livros.ContainsKey(codigo))
        {
            Livro l = livros[codigo];

            Console.WriteLine("\nLivro encontrado:");
            Console.WriteLine("Título: " + l.Titulo);
            Console.WriteLine("Autor: " + l.Autor);
            Console.WriteLine("Ano: " + l.Ano);
            Console.WriteLine("Quantidade: " + l.Quantidade);
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }


    static void EmprestarLivro()
    {
        Console.Write("\nDigite o código do livro para empréstimo: ");
        int codigo = int.Parse(Console.ReadLine());

        if (livros.ContainsKey(codigo))
        {
            Livro l = livros[codigo];

            if (l.Quantidade > 0)
            {
                l.Quantidade--;

                livros[codigo] = l;

                Console.WriteLine("Empréstimo realizado.");
                Console.WriteLine("Quantidade restante: " + l.Quantidade);
            }
            else
            {
                Console.WriteLine("Não existem exemplares disponíveis.");
            }
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }


    static void ExibirRelatorio()
    {
        Console.WriteLine("\nRELATÓRIO");

        Console.WriteLine("Total de livros cadastrados: " + livros.Count);


   
        Livro antigo = new Livro();
        int menorAno = int.MaxValue;

       
        Livro maiorQuantidade = new Livro();
        int maior = -1;


        foreach (KeyValuePair<int, Livro> item in livros)
        {
            Livro l = item.Value;

            if (l.Ano < menorAno)
            {
                menorAno = l.Ano;
                antigo = l;
            }

            if (l.Quantidade > maior)
            {
                maior = l.Quantidade;
                maiorQuantidade = l;
            }
        }


        Console.WriteLine("\nLivro mais antigo:");
        Console.WriteLine(antigo.Titulo + " - " + antigo.Ano);


        Console.WriteLine("\nLivro com maior quantidade disponível:");
        Console.WriteLine(maiorQuantidade.Titulo +
                          " - " + maiorQuantidade.Quantidade +
                          " exemplares");


        
        Console.WriteLine("\nQuantidade de livros por autor:");

        Dictionary<string, int> autores = new Dictionary<string, int>();

        foreach (KeyValuePair<int, Livro> item in livros)
        {
            string autor = item.Value.Autor;

            if (autores.ContainsKey(autor))
                autores[autor]++;
            else
                autores[autor] = 1;
        }


        foreach (KeyValuePair<string, int> autor in autores)
        {
            Console.WriteLine(autor.Key + ": "
                + autor.Value + " livro(s)");
        }
    }


    static void Main()
    {
        CadastrarLivro();

        int opcao;

        do
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1 - Buscar livro");
            Console.WriteLine("2 - Emprestar livro");
            Console.WriteLine("3 - Exibir relatório");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    BuscarLivro();
                    break;

                case 2:
                    EmprestarLivro();
                    break;

                case 3:
                    ExibirRelatorio();
                    break;

                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }
}