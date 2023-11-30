using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }

    static List<Task> tasks = new List<Task>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Criar Tarefa");
            Console.WriteLine("2. Listar Todas as Tarefas");
            Console.WriteLine("3. Marcar Tarefa como Concluída");
            Console.WriteLine("4. Listar Tarefas Pendentes");
            Console.WriteLine("5. Listar Tarefas Concluídas");
            Console.WriteLine("6. Excluir Tarefa");
            Console.WriteLine("7. Pesquisar Tarefas por Palavra-chave");
            Console.WriteLine("8. Exibir Estatísticas");
            Console.WriteLine("9. Sair");

            int choice = GetIntInput("Escolha uma opção: ");

            switch (choice)
            {
                case 1:
                    CreateTask();
                    break;
                case 2:
                    ListAllTasks();
                    break;
                case 3:
                    MarkTaskAsCompleted();
                    break;
                case 4:
                    ListPendingTasks();
                    break;
                case 5:
                    ListCompletedTasks();
                    break;
                case 6:
                    DeleteTask();
                    break;
                case 7:
                    SearchTasksByKeyword();
                    break;
                case 8:
                    DisplayStatistics();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CreateTask()
    {
        Task newTask = new Task();

        Console.Write("Título da Tarefa: ");
        newTask.Title = Console.ReadLine();

        Console.Write("Descrição da Tarefa: ");
        newTask.Description = Console.ReadLine();

        newTask.DueDate = GetDateTimeInput("Data de Vencimento (dd/mm/yyyy): ");

        tasks.Add(newTask);
        Console.WriteLine("Tarefa criada com sucesso!");
    }

    static void ListAllTasks()
    {
        Console.WriteLine("\nLista de Todas as Tarefas:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"- {task.Title} ({(task.IsCompleted ? "Concluída" : "Pendente")})");
        }
        Console.WriteLine();
    }

    static void MarkTaskAsCompleted()
    {
        Console.WriteLine("\nTarefas Pendentes:");
        ListPendingTasks();

        int taskIndex = GetIntInput("Digite o índice da tarefa que deseja marcar como concluída: ");

        if (taskIndex >= 0 && taskIndex < tasks.Count && !tasks[taskIndex].IsCompleted)
        {
            tasks[taskIndex].IsCompleted = true;
            Console.WriteLine("Tarefa marcada como concluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido ou tarefa já concluída.");
        }
    }

    static void ListPendingTasks()
    {
        Console.WriteLine("\nLista de Tarefas Pendentes:");
        for (int i = 0; i < tasks.Count; i++)
        {
            if (!tasks[i].IsCompleted)
            {
                Console.WriteLine($"[{i}] {tasks[i].Title} (Vencimento: {tasks[i].DueDate.ToString("dd/MM/yyyy")})");
            }
        }
        Console.WriteLine();
    }

    static void ListCompletedTasks()
    {
        Console.WriteLine("\nLista de Tarefas Concluídas:");
        foreach (var task in tasks.Where(t => t.IsCompleted))
        {
            Console.WriteLine($"- {task.Title} (Concluída em: {task.DueDate.ToString("dd/MM/yyyy")})");
        }
        Console.WriteLine();
    }

    static void DeleteTask()
    {
        Console.WriteLine("\nLista de Todas as Tarefas:");
        ListAllTasks();

        int taskIndex = GetIntInput("Digite o índice da tarefa que deseja excluir: ");

        if (taskIndex >= 0 && taskIndex < tasks.Count)
        {
            tasks.RemoveAt(taskIndex);
            Console.WriteLine("Tarefa excluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido.");
        }
    }

    static void SearchTasksByKeyword()
    {
        string keyword = Console.ReadLine().ToLower();

        var matchingTasks = tasks.Where(t =>
            t.Title.ToLower().Contains(keyword) || t.Description.ToLower().Contains(keyword)
        );

        Console.WriteLine($"\nTarefas que contêm '{keyword}':");
        foreach (var task in matchingTasks)
        {
            Console.WriteLine($"- {task.Title} ({(task.IsCompleted ? "Concluída" : "Pendente")})");
        }
        Console.WriteLine();
    }

    static void DisplayStatistics()
    {
        Console.WriteLine($"\nEstatísticas:");
        Console.WriteLine($"- Número de Tarefas Concluídas: {tasks.Count(t => t.IsCompleted)}");
        Console.WriteLine($"- Número de Tarefas Pendentes: {tasks.Count(t => !t.IsCompleted)}");

        var oldestTask = tasks.OrderBy(t => t.DueDate).FirstOrDefault();
        var newestTask = tasks.OrderByDescending(t => t.DueDate).FirstOrDefault();

        if (oldestTask != null)
        {
            Console.WriteLine($"- Tarefa mais antiga: {oldestTask.Title} (Vencimento: {oldestTask.DueDate.ToString("dd/MM/yyyy")})");
        }

        if (newestTask != null)
        {
            Console.WriteLine($"- Tarefa mais recente: {newestTask.Title} (Vencimento: {newestTask.DueDate.ToString("dd/MM/yyyy")})");
        }

        Console.WriteLine();
    }

    static int GetIntInput(string message)
    {
        Console.Write(message);
        int input;
        while (!int.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Entrada inválida. Tente novamente.");
            Console.Write(message);
        }
        return input;
    }

    static DateTime GetDateTimeInput(string message)
    {
        Console.Write(message);
        DateTime input;
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/mm/yyyy", null, System.Globalization.DateTimeStyles.None, out input))
        {
            Console.WriteLine("Formato de data inválido. Use o formato dd/mm/yyyy. Tente novamente.");
            Console.Write(message);
        }
        return input;
    }
}
