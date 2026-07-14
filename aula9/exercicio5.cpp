#include <iostream>
#include <map>
#include <string>

using namespace std;

int main() {
    map<string, string> jogos;
    string nome, genero;

   
    cout << "Cadastro de jogos\n";

    for (int i = 1; i <= 5; i++) {
        cout << "\nNome do jogo: ";
        cin.ignore(i == 1 ? 0 : 0);
        getline(cin, nome);

        cout << "Genero: ";
        getline(cin, genero);

        jogos[nome] = genero;
    }


    cout << "\nDigite o nome do jogo que deseja consultar: ";
    getline(cin, nome);

    if (jogos.find(nome) != jogos.end()) {
        cout << "Genero: " << jogos[nome] << endl;
    } else {
        cout << "Jogo nao cadastrado." << endl;
    }

    return 0;
}