using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        LinkedList<int> lista = new LinkedList<int>();

    
        for (int i = 0; i < 100; i++)
        {
            lista.AddLast(rnd.Next(1, 101)); 
        }

        
        bool trocou;
        do
        {
            trocou = false;
            LinkedListNode<int> atual = lista.First;

            while (atual != null && atual.Next != null)
            {
                if (atual.Value > atual.Next.Value)
                {
                    int aux = atual.Value;
                    atual.Value = atual.Next.Value;
                    atual.Next.Value = aux;
                    trocou = true;
                }
                atual = atual.Next;
            }
        } while (trocou);

        Console.WriteLine("Lista ordenada:");
        foreach (int n in lista)
            Console.Write(n + " ");

        Console.WriteLine();

       
        LinkedListNode<int> no = lista.First;
        while (no != null)
        {
            LinkedListNode<int> proximo = no.Next;

            if (no.Value % 2 == 0)
                lista.Remove(no);

            no = proximo;
        }

        Console.WriteLine("\nLista sem os pares:");
        foreach (int n in lista)
            Console.Write(n + " ");

        Console.WriteLine("\n\nNúmeros repetidos:");

        bool encontrou = false;

        LinkedListNode<int> p = lista.First;

        while (p != null)
        {
            int cont = 0;

            LinkedListNode<int> q = lista.First;
            while (q != null)
            {
                if (q.Value == p.Value)
                    cont++;

                q = q.Next;
            }

           
            bool primeira = true;
            q = lista.First;
            while (q != p)
            {
                if (q.Value == p.Value)
                {
                    primeira = false;
                    break;
                }
                q = q.Next;
            }

            if (cont > 1 && primeira)
            {
                Console.WriteLine(p.Value);
                encontrou = true;
            }

            p = p.Next;
        }

        if (!encontrou)
            Console.WriteLine("Não há números repetidos.");
    }
}