#include <iostream>
using namespace std;

int main()
{
    string cidades[4] = {
        "Vitoria",
        "Belo Horizonte",
        "Rio de Janeiro",
        "Sao Paulo"
    };

    int distancia[4][4] = {
        {0,   524, 521, 882},
        {524, 0,   434, 586},
        {521, 434, 0,   429},
        {882, 586, 429, 0}
    };

    int origem, destino;

    do
    {
        cout << "\nCidades:\n";
        cout << "0 - Vitoria\n";
        cout << "1 - Belo Horizonte\n";
        cout << "2 - Rio de Janeiro\n";
        cout << "3 - Sao Paulo\n";

        cout << "\nEscolha a cidade de origem: ";
        cin >> origem;

        cout << "Escolha a cidade de destino: ";
        cin >> destino;

        if (origem != destino)
        {
            cout << "Distancia entre "
                 << cidades[origem] << " e "
                 << cidades[destino] << ": "
                 << distancia[origem][destino]
                 << " km\n";
        }

    } while (origem != destino);

    cout << "\nOrigem e destino iguais. Programa encerrado." << endl;

    return 0;
}