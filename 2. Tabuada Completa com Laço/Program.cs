using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int numero;

        // Tenta converter a entrada do usuário para um número inteiro
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Por favor, digite um número válido:");
        }

        Console.WriteLine($"\nTabuada de {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
