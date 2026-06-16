#include <iostream>
#include <array>
using namespace std;

struct livro {
 string titulo;
 string autor;
 int anopublicacao;
 int numeropaginas;
 int preco;

};
int main()
{
array<livro, 3> livros;
for (int i = 0; i < livros.size(); i++) {
 cout << "Digite o título do livro: ";
 cin >> livros[i].titulo;
 cout << "Digite o autor do livro: ";
 cin >> livros[i].autor;
 cout << "Digite o ano de publicação do livro: ";
 cin >> livros[i].anopublicacao;
 cout << "Digite o número de páginas do livro: ";
 cin >> livros[i].numeropaginas;
 cout << "Digite o preço do livro: ";
 cin >> livros[i].preco;
}
int preco=0;
int media= (livros[0].numeropaginas + livros[1].numeropaginas + livros[2].numeropaginas) / 3;
preco= livros[0].preco + livros[1].preco + livros[2].preco;
cout << "O valor total é de " << preco << endl;
cout << "A média de páginas é: " << media << endl;
}