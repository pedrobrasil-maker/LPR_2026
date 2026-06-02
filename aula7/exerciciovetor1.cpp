#include <iostream>
#include <vector>

using namespace std;

int main() {
    
    std::vector<int> numeros(10);
    

    std::vector<int> numerosPar;
    std::vector<int> numerosImpar;

    
    for (int i = 0; i < numeros.size(); i++) {
        std::cout << "Digite o " << i + 1 << "º número: ";
        std::cin >> numeros[i];
        
        
        if (numeros[i] % 2 == 0) {
          
            numerosPar.push_back(numeros[i]); 
        } else {
        
            numerosImpar.push_back(numeros[i]); 
        }
    }

    std::cout << "\n--- RESULTADOS ---\n";

  
    std::cout << "Números pares digitados: ";
    for (int i = 0; i < numerosPar.size(); i++) {
        std::cout << numerosPar[i] << " ";
    }
    std::cout << std::endl;


    std::cout << "Números ímpares digitados: ";
    for (int i = 0; i < numerosImpar.size(); i++) {
        std::cout << numerosImpar[i] << " ";
    }
    std::cout << std::endl;

    return 0;
}