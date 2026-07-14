
using System;

class Program
{
    static void CadastrarHeroi(ref string nome, ref string poder, ref int pontuacao)
    {
        Console.Write("Nome do herói: ");
        nome = Console.ReadLine();

        Console.Write("Poder: ");
        poder = Console.ReadLine();

        Console.Write("Pontuação: ");
        pontuacao = int.Parse(Console.ReadLine());
    }

    static void SelecionarEquipe(
        string nome1, string poder1, int pont1,
        string nome2, string poder2, int pont2,
        string nome3, string poder3, int pont3,
        string nome4, string poder4, int pont4,
        string nome5, string poder5, int pont5,
        ref string eqNome1, ref string eqPoder1, ref int eqPont1,
        ref string eqNome2, ref string eqPoder2, ref int eqPont2,
        ref string eqNome3, ref string eqPoder3, ref int eqPont3)
    {
        Console.WriteLine("1 - " + nome1);
        Console.WriteLine("2 - " + nome2);
        Console.WriteLine("3 - " + nome3);
        Console.WriteLine("4 - " + nome4);
        Console.WriteLine("5 - " + nome5);

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Escolha o herói " + i + ": ");
            int op = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                if (op == 1) { eqNome1 = nome1; eqPoder1 = poder1; eqPont1 = pont1; }
                else if (op == 2) { eqNome1 = nome2; eqPoder1 = poder2; eqPont1 = pont2; }
                else if (op == 3) { eqNome1 = nome3; eqPoder1 = poder3; eqPont1 = pont3; }
                else if (op == 4) { eqNome1 = nome4; eqPoder1 = poder4; eqPont1 = pont4; }
                else if (op == 5) { eqNome1 = nome5; eqPoder1 = poder5; eqPont1 = pont5; }
            }

            if (i == 2)
            {
                if (op == 1) { eqNome2 = nome1; eqPoder2 = poder1; eqPont2 = pont1; }
                else if (op == 2) { eqNome2 = nome2; eqPoder2 = poder2; eqPont2 = pont2; }
                else if (op == 3) { eqNome2 = nome3; eqPoder2 = poder3; eqPont2 = pont3; }
                else if (op == 4) { eqNome2 = nome4; eqPoder2 = poder4; eqPont2 = pont4; }
                else if (op == 5) { eqNome2 = nome5; eqPoder2 = poder5; eqPont2 = pont5; }
            }

            if (i == 3)
            {
                if (op == 1) { eqNome3 = nome1; eqPoder3 = poder1; eqPont3 = pont1; }
                else if (op == 2) { eqNome3 = nome2; eqPoder3 = poder2; eqPont3 = pont2; }
                else if (op == 3) { eqNome3 = nome3; eqPoder3 = poder3; eqPont3 = pont3; }
                else if (op == 4) { eqNome3 = nome4; eqPoder3 = poder4; eqPont3 = pont4; }
                else if (op == 5) { eqNome3 = nome5; eqPoder3 = poder5; eqPont3 = pont5; }
            }
        }
    }

    static int CalcularPontuacaoTotal(int p1, int p2, int p3)
    {
        return p1 + p2 + p3;
    }

    static void ExibirEquipe(
        string nome1, string poder1, int pont1,
        string nome2, string poder2, int pont2,
        string nome3, string poder3, int pont3)
    {
        Console.WriteLine();
        Console.WriteLine("Equipe:");
        Console.WriteLine(nome1 + " - " + poder1 + " - " + pont1);
        Console.WriteLine(nome2 + " - " + poder2 + " - " + pont2);
        Console.WriteLine(nome3 + " - " + poder3 + " - " + pont3);
        Console.WriteLine("Pontuação Total: " + CalcularPontuacaoTotal(pont1, pont2, pont3));
    }

    static int MenuPrincipal()
    {
        Console.WriteLine();
        Console.WriteLine("1 - Cadastrar Heróis");
        Console.WriteLine("2 - Selecionar Equipe");
        Console.WriteLine("3 - Exibir Equipe");
        Console.WriteLine("0 - Sair");
        Console.Write("Opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void Main()
    {
        string nome1 = "", nome2 = "", nome3 = "", nome4 = "", nome5 = "";
        string poder1 = "", poder2 = "", poder3 = "", poder4 = "", poder5 = "";
        int pont1 = 0, pont2 = 0, pont3 = 0, pont4 = 0, pont5 = 0;

        string eqNome1 = "", eqNome2 = "", eqNome3 = "";
        string eqPoder1 = "", eqPoder2 = "", eqPoder3 = "";
        int eqPont1 = 0, eqPont2 = 0, eqPont3 = 0;

        int op;

        do
        {
            op = MenuPrincipal();

            switch (op)
            {
                case 1:
                    CadastrarHeroi(ref nome1, ref poder1, ref pont1);
                    CadastrarHeroi(ref nome2, ref poder2, ref pont2);
                    CadastrarHeroi(ref nome3, ref poder3, ref pont3);
                    CadastrarHeroi(ref nome4, ref poder4, ref pont4);
                    CadastrarHeroi(ref nome5, ref poder5, ref pont5);
                    break;

                case 2:
                    SelecionarEquipe(
                        nome1, poder1, pont1,
                        nome2, poder2, pont2,
                        nome3, poder3, pont3,
                        nome4, poder4, pont4,
                        nome5, poder5, pont5,
                        ref eqNome1, ref eqPoder1, ref eqPont1,
                        ref eqNome2, ref eqPoder2, ref eqPont2,
                        ref eqNome3, ref eqPoder3, ref eqPont3);
                    break;

                case 3:
                    ExibirEquipe(
                        eqNome1, eqPoder1, eqPont1,
                        eqNome2, eqPoder2, eqPont2,
                        eqNome3, eqPoder3, eqPont3);
                    break;
            }

        } while (op != 0);
    }
}

