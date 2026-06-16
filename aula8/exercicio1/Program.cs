using System;
class aula8 {
 // Declaração da Struct
 public struct filme {
 public string titulo;
 public string diretor;
 public int anolancamento;
 public int duracaominutos;
 }
 static void Main()
 {

//filme f1 = new filme { titulo = "O Poderoso Chefão", diretor = "Francis Ford Coppola", anolancamento = 1972, duracaominutos = 175 };
filme[] f = new filme[3];
for(int i = 0; i < 3; i++)
{

Console.WriteLine("Digite o título do filme:");
f[i].titulo = Console.ReadLine();
Console.WriteLine("Digite o diretor do filme:");
f[i].diretor = Console.ReadLine();
Console.WriteLine("Digite o ano de lançamento do filme:");
f[i].anolancamento = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a duração do filme (em minutos):");
f[i].duracaominutos = int.Parse(Console.ReadLine());
}
if(f[0].anolancamento < f[1].anolancamento && f[0].anolancamento < f[2].anolancamento)
{
Console.WriteLine("O filme mais antigo é: {0}", f[0].titulo);
}
else if(f[1].anolancamento < f[2].anolancamento)
{
Console.WriteLine("O filme mais antigo é: {0}", f[1].titulo);
}
else
{
Console.WriteLine("O filme mais antigo é: {0}", f[2].titulo);
}

 }
 }

