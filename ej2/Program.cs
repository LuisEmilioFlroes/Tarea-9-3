using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una frase:");
        string frase = Console.ReadLine();

        
        string[] palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        
        int numpalabras = palabras.Length;
        int numvocales = 0;

        
        foreach (string palabra in palabras)
        {
            foreach (char caracter in palabra.ToLower())
            {
                if (EsVocal(caracter))
                {
                    numvocales++;
                }
            }
        }

        Console.WriteLine($"Número de palabras: {numpalabras}");
        Console.WriteLine($"Número de vocales: {numvocales}");
    }

    
    static bool EsVocal(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
