#include <iostream>
#include <iomanip>

using namespace std;
int main() {
    int n1, n2, n3, n4;
    cout << "Digite o primeiro número inteiro: ";
    cin >> n1;
    cout << "Digite o segundo número inteiro: ";
    cin >> n2;
    cout << "Digite o terceiro  número inteiro: ";
    cin >> n3;
        cout << "Digite o quarto número inteiro: ";
    cin >> n4;
    int diferença = (n1 * n2) - (n3 * n4);
    cout << "Diferença: " << diferença << endl;

    return 0;
}