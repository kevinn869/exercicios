using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma senha:");
        string senha = Console.ReadLine();

        if (ValidarSenha(senha))
        {
            Console.WriteLine("Senha forte!");
        }
        else
        {
            Console.WriteLine("Senha fraca. Certifique-se de que ela tenha pelo menos 8 caracteres, uma letra maiúscula, um número e um caractere especial.");
        }
    }

    static bool ValidarSenha(string senha)
    {
        if (senha.Length < 8)
            return false;

        if (!Regex.IsMatch(senha, "[A-Z]")) // Verifica se há pelo menos uma letra maiúscula
            return false;

        if (!Regex.IsMatch(senha, "[0-9]")) // Verifica se há pelo menos um número
            return false;

        if (!Regex.IsMatch(senha, "[!@#\\$%\\^&\\*]")) // Verifica se há pelo menos um caractere especial
            return false;

        return true;
    }
}
