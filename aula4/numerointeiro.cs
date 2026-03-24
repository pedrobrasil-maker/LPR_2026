using System;
class program
{
   static void Main(string[]args)
    {
        Console.WriteLine("digite um numero interiro");
        int numero = int.Parse( Console.ReadLine());   
        if (numero % 2 == 0)
        {
            Console.WriteLine("par");
        }
        else
        {
            Console.WriteLine("ímpar");
        }

    }

}