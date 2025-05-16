using System;

class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("🌡️  Conversor de Temperaturas");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1 - Celsius ➡ Fahrenheit");
            Console.WriteLine("2 - Fahrenheit ➡ Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("\nDigite sua opção: ");

            bool entradaValida = int.TryParse(Console.ReadLine(), out opcao);

            if (!entradaValida)
            {
                Console.WriteLine("\n❌ Opa! Isso não é um número válido.");
                Pausar();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    ConverterCelsiusParaFahrenheit();
                    break;

                case 2:
                    ConverterFahrenheitParaCelsius();
                    break;

                case 3:
                    Console.WriteLine("\n👋 Até a próxima! Fique quente... ou frio 😄");
                    break;

                default:
                    Console.WriteLine("\n❌ Opção inválida! Tente de novo.");
                    break;
            }

            if (opcao != 3)
                Pausar();

        } while (opcao != 3);
    }

    static void ConverterCelsiusParaFahrenheit()
    {
        Console.Write("\nDigite a temperatura em Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"🔥 {celsius}°C é igual a {fahrenheit:F2}°F");
        }
        else
        {
            Console.WriteLine("⚠️ Valor inválido. Tente novamente com um número.");
        }
    }

    static void ConverterFahrenheitParaCelsius()
    {
        Console.Write("\nDigite a temperatura em Fahrenheit: ");
        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"❄️ {fahrenheit}°F é igual a {celsius:F2}°C");
        }
        else
        {
            Console.WriteLine("⚠️ Valor inválido. Tente novamente com um número.");
        }
    }

    static void Pausar()
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
