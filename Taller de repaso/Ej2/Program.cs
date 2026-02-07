// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        string num = "1234";
        // RESULTADO CON NUMEROS ALEATORIOS
        //Random rnd = new Random();
        //string resultado = rnd.Next(1000, 10000).ToString();
        string resultado = "4321"; // numeros para probar
        int generico = 1000;

        int premio = CalcularPremio(num, resultado, generico);

        Console.WriteLine("Número apostado: " + num);
        Console.WriteLine("Número ganador: " + resultado);

        if (premio > 0)
            Console.WriteLine("Ganó $" + premio);
        else
            Console.WriteLine("No ganó nada");

        Console.ReadLine();
    }

    static int CalcularPremio(string num, string resultado, int generico)
    {
        if (num == resultado)
            return generico * 4500;

        if (EsDesorden(num, resultado))
            return generico * 200;

        if (num[1] == resultado[1] &&
            num[2] == resultado[2] &&
            num[3] == resultado[3])
            return generico * 400;

        if (num[2] == resultado[2] &&
            num[3] == resultado[3])
            return generico * 50;

        if (num[3] == resultado[3])
            return generico * 5;

        return 0;
    }

    static bool EsDesorden(string a, string b)
    {
        char[] x = a.ToCharArray();
        char[] y = b.ToCharArray();

        Array.Sort(x);
        Array.Sort(y);

        return new string(x) == new string(y);
    }
}

