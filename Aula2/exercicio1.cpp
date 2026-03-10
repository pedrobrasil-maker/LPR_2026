#include <iostream>
#include <iomanip>

using namespace std;

int main(){
    float pi = 3.14159f;
    cout<<"digite o valor do raio: ";
    float raio;
    cin>>raio;
    float area = pi * raio * raio;
    cout<<fixed<<setprecision(4)<<"A area do circulo e: "<<area<<endl;
}
