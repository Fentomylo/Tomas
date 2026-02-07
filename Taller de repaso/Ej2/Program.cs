// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        int generico = 1000; 
        int num = 4346;      
        
        Random random = new Random();
        int resultado = random.Next(1000, 10000); 

        Console.WriteLine("Genérico apuesta: $" + generico);
        Console.WriteLine("Número elegido: " + num);
        Console.WriteLine("Número ganador: " + resultado);

        if (num == resultado)
        {
            Console.WriteLine("Genérico ganó la apuesta");
        }
        else
        {
            Console.WriteLine("Genérico perdió la apuesta");
        }

        Console.ReadLine();
    }
}

