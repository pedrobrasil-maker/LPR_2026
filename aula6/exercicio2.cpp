#include <iostream>
using namespace std;

// Exercício 1
void mediaPares() {
    int quantidade;
    int acumulador = 0;
    int pares = 0;

    cout << "Quantos numeros serao digitados? ";
    cin >> quantidade;

    for (int i = 0; i < quantidade; i++) {
        int numero;
        cout << "Digite o " << (i + 1) << " numero: ";
        cin >> numero;

        if (numero % 2 == 0) {
            acumulador += numero;
            pares++;
        }
    }

    if (pares > 0) {
        double media = (double)acumulador / pares;
        cout << "A media dos numeros pares e: " << media << endl;
    } else {
        cout << "Nenhum numero par foi digitado." << endl;
    }
}

// Exercício 3
void somaImparesMultiplos3(int inicio, int fim) {
    int soma = 0;

    for (int i = inicio; i <= fim; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    cout << "A soma dos numeros eh: " << soma << endl;
}

// Exercício 4
void quadradoESomaDigitos(int numero) {
    int quadrado = numero * numero;
    int soma = 0;
    int temp = quadrado;

    while (temp > 0) {
        soma += temp % 10;
        temp /= 10;
    }

    cout << "Quadrado: " << quadrado << endl;
    cout << "Soma dos digitos: " << soma << endl;
}

int main() {
    int opcao;

    do {
        cout << "\n===== MENU =====" << endl;
        cout << "1 - Exercicio 1 (Media dos pares)" << endl;
        cout << "2 - Exercicio 3 (Soma dos impares multiplos de 3)" << endl;
        cout << "3 - Exercicio 4 (Quadrado e soma dos digitos)" << endl;
        cout << "0 - Sair" << endl;
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
        case 1:
            mediaPares();
            break;

        case 2:
            somaImparesMultiplos3(50, 500);
            break;

        case 3: {
            int numero;
            cout << "Digite um numero: ";
            cin >> numero;
            quadradoESomaDigitos(numero);
            break;
        }

        case 0:
            cout << "Encerrando o programa..." << endl;
            break;

        default:
            cout << "Opcao invalida!" << endl;
        }

    } while (opcao != 0);

    return 0;
}