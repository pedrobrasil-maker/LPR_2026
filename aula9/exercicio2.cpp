#include <iostream>
#include <list>
#include <string>

using namespace std;

int main() {
    int x;
    cin >> x;

    list<string> nomes;
    int maior = 0;

  
    for (int i = 0; i < x; i++) {
        string nome;
        cin >> nome;
        nomes.push_back(nome);

        if (nome.size() > maior)
            maior = nome.size();
    }

    
    while (!nomes.empty()) {
        bool primeiro = true;

        
        for (int tam = 1; tam <= maior; tam++) {

            for (auto it = nomes.begin(); it != nomes.end(); it++) {

                if (it->size() == tam) {

                    if (!primeiro)
                        cout << ", ";

                    cout << *it;

                    nomes.erase(it); 

                    primeiro = false;
                    break; 
                }
            }
        }

        cout << endl;
    }

    return 0;
}