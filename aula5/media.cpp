#include <iostream>

int main() {
    int i = 0;
    int acumulador = 0;
    int quantidade;
    int pares = 0;
    std::cout << "Quantos numeros serao digitados?" << std::endl;
    std::cin >> quantidade;
    while (i < quantidade) {
        std::cout << "Digite o " << (i+1) << "º numero: " << std::endl;
        int numero;
        std::cin >> numero;
     if (numero % 2 == 0) {
        acumulador += numero;
        pares++;
        }
    i++;
    }
    if (pares > 0) {
     double media = (double)acumulador / pares;
     std::cout << "A media dos pares e: " << media << std::endl;
    } else {
        std::cout << "Nenhum numero par foi digitado." << std::endl;
    }

    return 0;
}

