#include <iostream>
#include <list>
using namespace std;

int main() {
    list<int> notas(5);
    int nota, soma = 0;
    int maior, menor;

    
    for (int i = 0; i < 5; i++) {
        cout << "Digite a " << i + 1 << " nota: ";
        cin >> nota;
        notas.push_back(nota);

        soma += nota;

        if (i == 0) {
            maior = menor = nota;
        } else {
            if (nota > maior)
                maior = nota;

            if (nota < menor)
                menor = nota;
        }
    }

   
    cout << "\nNotas cadastradas:\n";
    for (const auto& n : notas) {
        cout << n   << " ";
    }

    
    float media = soma / notas.size();

    
    cout << "\n\nMaior nota: " << maior;
    cout << "\nMenor nota: " << menor;
    cout << "\nMedia das notas: " << media << endl;

    return 0;
}