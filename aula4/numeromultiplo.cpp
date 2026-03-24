#include <iostream>

int main() {
std::cout<<"Digite um numero inteiro"<<std::endl; 
int numero;
std::cin >> numero;
std::cout<<"Digite outro numero inteiro"<<std::endl; 
int numero2;
std::cin >> numero2;
if( numero%numero2 == 0 || numero2%numero == 0){
std::cout<<"os numeros sao multiplos"<<std::endl; 
}
else{
    std::cout<<"os numeros nao sao multiplos"<<std::endl; 
}
}
