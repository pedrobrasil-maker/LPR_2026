using System;
   class Programs

{
    static void Main()
    {
        Console.WriteLine("Digite seu número");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite quantas horas trabalhadas");
        int horas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite quanto voce ganha por hora");
        int QuantoPorHora = int.Parse(Console.ReadLine());
        int salario = horas * QuantoPorHora;
        Console.WriteLine("O salário é: " + salario);
        
    }
}