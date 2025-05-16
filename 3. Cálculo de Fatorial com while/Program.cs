using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro positivo:");
        int numero;

        // Garante que o usuário insira um número inteiro positivo válido
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo válido:");
        }

        long fatorial = 1;
        int contador = numero;

        while (contador > 1)
        {
            fatorial *= contador;
            contador--;
        }

        Console.WriteLine($"\nO fatorial de {numero} é {fatorial}");
    }
}
