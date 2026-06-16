#include <iostream>
#include <string>

using namespace std;

string ClassificarAluno(int nota)
{
    if (nota < 60)
    {
        return "Reprovado";
    }
    else if (nota <= 79)
    {
        return "Recuperacao";
    }
    else
    {
        return "Aprovado";
    }
}

int main()
{
    string nomes[10];
    int notas[10];

    cout << "Cadastro de alunos\n";

    for (int i = 0; i < 10; i++)
    {
        cout << "\nDigite o nome do aluno " << i + 1 << ": ";
        getline(cin, nomes[i]);

        cout << "Digite a nota de " << nomes[i] << " (0 a 100): ";
        cin >> notas[i];

        while (notas[i] < 0 || notas[i] > 100)
        {
            cout << "Nota invalida! Digite uma nota entre 0 e 100: ";
            cin >> notas[i];
        }

        cin.ignore();
    }

    cout << "\n--- Resultado da Turma ---\n";

    for (int i = 0; i < 10; i++)
    {
        cout << "Aluno: " << nomes[i]
             << " | Nota: " << notas[i]
             << " | Situacao: " << ClassificarAluno(notas[i])
             << endl;
    }

    return 0;
}