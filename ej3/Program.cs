using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();

        bool espalindromo = Espalindromo(palabra);

        if (espalindromo)
        {
            Console.WriteLine("La palabra que ingresó  es un palíndromo.");

        }
        else
        {
            Console.WriteLine("La palabra que ingresó no es un palíndromo.");
        }
    }

    static bool Espalindromo(string palabra)
    {
        int longitud = palabra.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
