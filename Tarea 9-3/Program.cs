using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        int mayor = int.MinValue;
        int menor = int.MaxValue;

        Console.WriteLine("Ingrese valores positivos (ingrese 0 para finalizar):");

        do
        {
            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                if (numero > mayor)
                {
                    mayor = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }
            else if (numero < 0)
            {
                Console.WriteLine("Ingrese solo valores positivos.");
            }

        } while (numero != 0);

        if (mayor != int.MinValue && menor != int.MaxValue)
        {
            Console.WriteLine("El número mayor ingresado fue: " + mayor);
            Console.WriteLine("El número menor ingresado fue: " + menor);
        }
        else
        {
            Console.WriteLine("No se ingresaron números válidos.");
        }
    }
}
