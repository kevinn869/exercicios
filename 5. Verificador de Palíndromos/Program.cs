using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("🔁 Verificador de Palíndromos 🔁");
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("⚠️ Entrada vazia. Tente novamente.");
            return;
        }

        string textoLimpo = RemoverAcentos(entrada.ToLower());
        textoLimpo = Regex.Replace(textoLimpo, @"[^a-z0-9]", ""); 

        char[] arr = textoLimpo.ToCharArray();
        Array.Reverse(arr);
        string invertido = new string(arr);

        if (textoLimpo == invertido)
        {
            Console.WriteLine("✅ É um palíndromo!");
        }
        else
        {
            Console.WriteLine("❌ Não é um palíndromo.");
        }
    }

    static string RemoverAcentos(string texto)
    {
        var textoNormalizado = texto.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        foreach (char c in textoNormalizado)
        {
            UnicodeCategory categoria = CharUnicodeInfo.GetUnicodeCategory(c);
            if (categoria != UnicodeCategory.NonSpacingMark)
            {
                sb.Append(c);
            }
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}
