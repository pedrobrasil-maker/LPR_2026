using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantas horas você treina por dia? ");
        double horasPorDia = double.Parse(Console.ReadLine());

        int diasTreinados = 0;
        double totalHoras = 0;

       
        while (totalHoras < 1000)
        {
            totalHoras += horasPorDia;
            diasTreinados++;
        }

        
        double semanas = diasTreinados / 5.0;

        
        double meses = semanas / 4.5;

        Console.WriteLine("\n=== Resultado do Treinamento Jedi ===");
        Console.WriteLine("Total de dias de treino: " + diasTreinados);
        Console.WriteLine("Total de semanas: " + semanas.ToString("F2"));
        Console.WriteLine("Total de meses: " + meses.ToString("F2"));
    }
}