/* ### 📝 Exercício 08 – Cálculo de IMC

#### 🔍 Lógica
1. Solicita o peso do usuário.
2. Solicita a altura.
3. Aplica a fórmula do IMC: IMC = peso / (altura * altura).
4. Compara o resultado com os critérios da OMS para classificar.

#### 🧱 Estruturas e Comandos Utilizados
- double.Parse(): para converter a entrada de texto em número com casas decimais.
- if / else if: para classificação de acordo com o IMC.

#### ✅ Justificativa
A estrutura if permite comparar intervalos numéricos de forma clara e direta. O uso de double é ideal para precisão com números decimais. */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine($"\nSeu IMC é: {imc:F2}");

        if (imc < 18.5)
            Console.WriteLine("Classificação: Abaixo do peso");
        else if (imc < 25)
            Console.WriteLine("Classificação: Peso normal");
        else if (imc < 30)
            Console.WriteLine("Classificação: Sobrepeso");
        else
            Console.WriteLine("Classificação: Obesidade");
    }
}
