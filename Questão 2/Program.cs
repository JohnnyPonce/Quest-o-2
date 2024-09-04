using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();

        int quantidadeA = VerificarQuantidadeA(input);

        if (quantidadeA > 0)
        {
            Console.WriteLine($"A letra 'a' ocorre {quantidadeA} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não ocorre na string.");
        }
    }

    static int VerificarQuantidadeA(string input)
    {
        int quantidadeA = 0;

        foreach (char c in input.ToLower())
        {
            if (c == 'a')
            {
                quantidadeA++;
            }
        }

        return quantidadeA;
    }
}