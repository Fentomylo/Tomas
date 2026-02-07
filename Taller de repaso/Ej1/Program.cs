// See https://aka.ms/new-console-template for more information

class Program
{
    // PRIMER EJERCICIO
    static void Main(string[] args)
    {
        FibonacciPrimos(10);
        Console.WriteLine("Ingresa la cantidad de segundos:");
        int segs = int.Parse(Console.ReadLine());


        string reloj = SegundosAHora(segs);

        Console.WriteLine("El formato es: " + reloj);
    }

    static void FibonacciPrimos(int n)
    {
        int a = 0, b = 1;

        for (int i = 1; i <= n; i++)
        {
            int actual = a;
            a = b;
            b = actual + b;

            if (EsPrimo(actual))
            {
                Console.WriteLine(actual);
            }
        }
    }

    static bool EsPrimo(int num)
    {
        if (num < 2) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }



    // SEGUNDO EJERCICIO

    static string SegundosAHora(int segundos)
    {
        int horas = segundos / 3600;
        int minutos = (segundos % 3600) / 60;
        int seg = segundos % 60;

        return $"{horas:D2}:{minutos:D2}:{seg:D2}";
    }
}
