#include <iostream>
#include <map>
#include <string>

using namespace std;

int main() {
    map<string, int> pessoas;

    int X;
    cout << "Quantidade de pessoas: ";
    cin >> X;

   
    for (int i = 0; i < X; i++) {
        string nome;
        int idade;

        cout << "\nNome: ";
        cin >> nome;

        cout << "Idade: ";
        cin >> idade;

        pessoas[nome] = idade;
    }

    
    int soma = 0;

    for (auto p : pessoas) {
        soma += p.second;
    }

    double media = (double)soma / pessoas.size();

    cout << "\nMedia das idades: " << media << endl;

    cout << "\nPessoas acima da media:\n";

    for (auto p : pessoas) {
        if (p.second > media) {
            cout << p.first << " - " << p.second << " anos" << endl;
        }
    }

   
    string maisVelha, maisNova;
    int maiorIdade = -1;
    int menorIdade = 999;

    for (auto p : pessoas) {
        if (p.second > maiorIdade) {
            maiorIdade = p.second;
            maisVelha = p.first;
        }

        if (p.second < menorIdade) {
            menorIdade = p.second;
            maisNova = p.first;
        }
    }

    cout << "\nPessoa mais velha: "
         << maisVelha << " - "
         << maiorIdade << " anos" << endl;

    cout << "Pessoa mais nova: "
         << maisNova << " - "
         << menorIdade << " anos" << endl;


   
    int Y;
    cout << "\nDigite a idade que deseja remover: ";
    cin >> Y;

    for (auto it = pessoas.begin(); it != pessoas.end(); ) {
        if (it->second == Y) {
            it = pessoas.erase(it);
        } else {
            it++;
        }
    }

  
    cout << "\nDicionario atualizado:\n";

    for (auto p : pessoas) {
        cout << p.first << " -> "
             << p.second << " anos" << endl;
    }

    return 0;
}