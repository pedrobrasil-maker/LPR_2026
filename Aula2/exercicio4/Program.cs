using System;
   class Programs

{
    static void Main()
    {
        Console.WriteLine("Digite o codigo da peça 1");
        int codigo1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o preço da peça 1");
        int preco1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite a quantidade da peça 1");
        int quantidade1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Digite o codigo da peça 2");
        int codigo2 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o preço da peça 2");
        int preco2 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite a quantidade da peça 2");
        int quantidade2 = int.Parse(Console.ReadLine());
int total = (preco1 * quantidade1) + (preco2 * quantidade2);
        Console.WriteLine("O valor a ser pago é: " + total);    
    }
}