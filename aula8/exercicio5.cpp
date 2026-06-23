#include <iostream>
#include <array>

using namespace std;

struct Chamado
{
    int numero;
    string solicitante;
    string setor;
    int prioridade;
    string status;
    string descricao;
};

array<Chamado, 10> chamados;
int qtdChamados = 0;

int menu()
{
    int opcao;

    cout << "\n1 - Cadastrar chamado" << endl;
    cout << "2 - Listar chamados" << endl;
    cout << "3 - Atualizar status" << endl;
    cout << "4 - Estatisticas" << endl;
    cout << "5 - Classificar prioridade" << endl;
    cout << "6 - Sair" << endl;
    cout << "Opcao: ";
    cin >> opcao;

    return opcao;
}

string classificarPrioridade(int prioridade)
{
    if (prioridade == 1)
        return "Baixa";
    else if (prioridade == 2)
        return "Media";
    else if (prioridade == 3)
        return "Alta";

    return "Invalida";
}

void cadastrarChamado()
{
    if (qtdChamados >= 10)
    {
        cout << "Limite de chamados atingido." << endl;
        return;
    }

    cout << "Numero: ";
    cin >> chamados[qtdChamados].numero;

    cout << "Solicitante: ";
    cin >> chamados[qtdChamados].solicitante;

    cout << "Setor: ";
    cin >> chamados[qtdChamados].setor;

    cout << "Prioridade (1-Baixa, 2-Media, 3-Alta): ";
    cin >> chamados[qtdChamados].prioridade;

    cout << "Descricao: ";
    cin >> chamados[qtdChamados].descricao;

    chamados[qtdChamados].status = "Aberto";

    qtdChamados++;
}

void listarChamados()
{
    if (qtdChamados == 0)
    {
        cout << "Nenhum chamado cadastrado." << endl;
        return;
    }

    for (int i = 0; i < qtdChamados; i++)
    {
        cout << "\nNumero: " << chamados[i].numero << endl;
        cout << "Solicitante: " << chamados[i].solicitante << endl;
        cout << "Setor: " << chamados[i].setor << endl;
        cout << "Prioridade: " << classificarPrioridade(chamados[i].prioridade) << endl;
        cout << "Status: " << chamados[i].status << endl;
        cout << "Descricao: " << chamados[i].descricao << endl;
    }
}

void atualizarStatus()
{
    int numero;
    int opcao;

    cout << "Numero do chamado: ";
    cin >> numero;

    for (int i = 0; i < qtdChamados; i++)
    {
        if (chamados[i].numero == numero)
        {
            cout << "1 - Em_andamento" << endl;
            cout << "2 - Resolvido" << endl;
            cout << "3 - Cancelado" << endl;
            cout << "Opcao: ";
            cin >> opcao;

            if (opcao == 1)
                chamados[i].status = "Em_andamento";
            else if (opcao == 2)
                chamados[i].status = "Resolvido";
            else if (opcao == 3)
                chamados[i].status = "Cancelado";

            cout << "Status atualizado." << endl;
            return;
        }
    }

    cout << "Chamado nao encontrado." << endl;
}

void estatisticas()
{
    int abertos = 0;
    int andamento = 0;
    int resolvidos = 0;
    int cancelados = 0;

    for (int i = 0; i < qtdChamados; i++)
    {
        if (chamados[i].status == "Aberto")
            abertos++;
        else if (chamados[i].status == "Em_andamento")
            andamento++;
        else if (chamados[i].status == "Resolvido")
            resolvidos++;
        else if (chamados[i].status == "Cancelado")
            cancelados++;
    }

    cout << "Abertos: " << abertos << endl;
    cout << "Em andamento: " << andamento << endl;
    cout << "Resolvidos: " << resolvidos << endl;
    cout << "Cancelados: " << cancelados << endl;
}

int main()
{
    int opcao;

    do
    {
        opcao = menu();

        switch (opcao)
        {
            case 1:
                cadastrarChamado();
                break;

            case 2:
                listarChamados();
                break;

            case 3:
                atualizarStatus();
                break;

            case 4:
                estatisticas();
                break;

            case 5:
            {
                int prioridade;
                cout << "Digite a prioridade: ";
                cin >> prioridade;
                cout << classificarPrioridade(prioridade) << endl;
                break;
            }

            case 6:
                cout << "Programa encerrado." << endl;
                break;

            default:
                cout << "Opcao invalida." << endl;
        }

    } while (opcao != 6);

    return 0;
}