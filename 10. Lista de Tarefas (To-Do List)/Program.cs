/* 
### 📝 Exercício 10 – Lista de Tarefas

#### 🔍 Lógica
1. Cria duas listas: uma para tarefas e outra para marcar se estão concluídas.
2. Exibe um menu com opções de adicionar, listar e concluir tarefas.
3. O loop do...while garante repetição até o usuário escolher sair.
4. A opção de marcar tarefas atualiza o status para concluído.

#### 🧱 Estruturas e Comandos Utilizados
- List<string> e List<bool> para armazenar tarefas e seu estado.
- switch: para tratar as opções do menu.
- for: para listar as tarefas com seus status.

#### ✅ Justificativa
Listas são ideais para armazenar dados dinâmicos. O uso do switch torna o menu claro, e a separação do status facilita a lógica de exibição.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluidas = new List<bool>();
        string opcao;

        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Marcar como Concluída");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a tarefa: ");
                    string tarefa = Console.ReadLine();
                    tarefas.Add(tarefa);
                    concluidas.Add(false);
                    break;

                case "2":
                    Console.WriteLine("\n--- Lista de Tarefas ---");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluidas[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }
                    break;

                case "3":
                    Console.Write("Digite o número da tarefa para marcar como concluída: ");
                    int indice = int.Parse(Console.ReadLine()) - 1;
                    if (indice >= 0 && indice < concluidas.Count)
                    {
                        concluidas[indice] = true;
                        Console.WriteLine("Tarefa marcada como concluída.");
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != "4");
    }
}

