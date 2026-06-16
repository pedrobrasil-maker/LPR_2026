#include <iostream>
#include <array>
using namespace std;

struct produto {
 string Nome;
 int codigo;
 int quantidade;
 int preco;

};
int main()
{
array<produto, 3> produtos;
for (int i = 0; i < produtos.size(); i++) {
 cout << "Digite o nome do produto: ";
 cin >> produtos[i].Nome;
 cout << "Digite o código do produto: ";
 cin >> produtos[i].codigo;
 cout << "Digite a quantidade do produto: ";
 cin >> produtos[i].quantidade;
 cout << "Digite o preço do produto: ";
 cin >> produtos[i].preco;
}
int total = 0;
for (int i = 0; i < produtos.size(); i++) {
 total += produtos[i].quantidade * produtos[i].preco;
}
cout << "O valor total do estoque é: " << total << endl;
}