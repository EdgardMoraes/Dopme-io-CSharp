// See https://aka.ms/new-console-template for more information

using System.Globalization;
using ToDoList;

List<Tarefa> tarefas = new List<Tarefa>();

int proximoId = 1;

bool continuar = true;
while (continuar)
{
    ExibirMenu();
    int opcao = LerOpcao();

    switch (opcao)
    {
        case 1:
            AdicionarTarefa();
            break;
        case 2:
            ListarTarefa();
            break;
        case 3:
            MarcarComoConcluida();
            break;
        case 4:
            RemoverTarefa();
            break;
        case 5:
            ListarPendentes();
            break;
        case 6:
            ListarConcluidas();
            break;
        case 0:
            continuar = false;
            Console.WriteLine("Encerrando...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    if (continuar)
    {
        AguardarTecla();
    }

    static void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════════╗");
        Console.WriteLine("║ SISTEMA DE GERENCIAMENTO DE        ║");
        Console.WriteLine("║          TAREFAS                   ║");
        Console.WriteLine("╚════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("1. Adicionar Tarefa");
        Console.WriteLine("2. Listar Todas as Tarefas");
        Console.WriteLine("3. Marcar Tarefa como Concluída");
        Console.WriteLine("4. Remover Tarefa");
        Console.WriteLine("5. Listar Tarefas Pendentes");
        Console.WriteLine("6. Listar Tarefas Concluídas");
        Console.WriteLine("0. Sair");
        Console.WriteLine();
        Console.Write("Escolha uma opção: ");
    }

    static int LerOpcao()
    {
        return int.Parse(Console.ReadLine());
    }

    static void AguardarTecla()
    {
        Console.WriteLine("\nPressione wualquer tecla para continuar...");
        Console.ReadKey();
    }

    void AdicionarTarefa()
    {
        Console.Clear();
        Console.WriteLine("Adicionar Nova Tarefa\n");

        string descricao = Console.ReadLine();
        int id = proximoId;

        if (string.IsNullOrEmpty(descricao))
        {
            Console.WriteLine("Descrição não pode ser vazia");
            return;
        }

        Tarefa novaTarefa = new Tarefa(proximoId++, descricao);
        tarefas.Add(novaTarefa);
        Console.WriteLine($"\n Tarefa #{novaTarefa.Id} Adicionada com sucesso");
    }

    void ListarTarefa()
    {
        Console.Clear();
        Console.WriteLine(" Listar todas as tarefas");

        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada!");
            return;
        }

        foreach (var tarefa in tarefas)
        {
            string status = tarefa.Concluida ? " Concluída" : " Pendente";
            string descricao = tarefa.Descricao.Length > 30
                ? tarefa.Descricao.Substring(0, 27) + "..."
                : tarefa.Descricao;

            Console.WriteLine($"{tarefa.Id,-3} | {status,-9} | {descricao}");
        }

        Console.WriteLine($"\nTotal: {tarefas.Count} tarefa(s)");
    }

     void MarcarComoConcluida()
    {
        Console.Clear();
        Console.WriteLine("Marcar tarefa como concluída");

        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nehuma tarefa cadastrada.");
            return;
        }
        
        ListarTarefasPorStatus(false);
        Console.WriteLine("\nDigite o ID da tarefa: ");
        if (!int.TryParse(Console.ReadLine(),out int id))
        {
            Console.WriteLine("ID inválido!");
            return;
        }

        Tarefa tarefa = EncontrarTarefaPorId(id);

        if (tarefa == null)
        {
            Console.WriteLine("Tarefa não encontrada");
            return;
        }

        if (tarefa.Concluida)
        {
            Console.WriteLine("Esta tarefa já está concluída");
        }

        tarefa.Concluida = true;
        Console.WriteLine($"\nTarefa #{id} marcada como concluída!");
    }

    void RemoverTarefa()
    {
        Console.Clear();
        Console.WriteLine(" Remover tarefa");
        if (tarefas.Count == 0 )
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
            return;
        }
        
        ListarTarefa();
        
        Console.WriteLine("\nDigite o ID da tarefa: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            return;
        }

        Tarefa tarefa = EncontrarTarefaPorId(id);
        if (tarefa == null)
        {
            Console.WriteLine("Tarefa não encontrada");
            return;
        }

        Console.WriteLine($"Deseja realmente remover '{{tarefa.Descricao}}'? (S/N):");
        string confirmacao = Console.ReadLine().ToUpper();

        if (confirmacao == "S")
        {
            tarefas.Remove(tarefa);
        }

    }

    Tarefa EncontrarTarefaPorId(int id)
    {
        foreach (Tarefa tarefa in tarefas)
        {
            if (tarefa.Id == id)
            {
                return tarefa;
            }
        }

        return null;
    }

    void ListarTarefasPorStatus(bool concluida)
    {
        string statusTexto = concluida ? "Concluídas" : "Pendentes";
        int contador = 0;
        Console.WriteLine($"Tarefas {statusTexto}:");
        Console.WriteLine("ID | Descrição");
        Console.WriteLine("---|---------------------------------");

        foreach (Tarefa tarefa in tarefas)
        {
            if (tarefa.Concluida == concluida)
            {
                string descricao = tarefa.Descricao.Length > 30
                    ? tarefa.Descricao.Substring(0, 27) + "..."
                    : tarefa.Descricao;

                Console.WriteLine($"{tarefa.Id,-3} | {descricao}");
                contador++;
            }
        }

        if (contador == 0)
        {
            Console.WriteLine($"Nenhuma tarefa {statusTexto.ToLower()}.");
        }
        
    }
    
    void ListarPendentes()
    {
        Console.Clear();
        Console.WriteLine("=== TAREFAS PENDENTES ===\n");
        ListarTarefasPorStatus(false);
    }
    void ListarConcluidas()
    {
        Console.Clear();
        Console.WriteLine("=== TAREFAS CONCLUÍDAS ===\n");
        ListarTarefasPorStatus(true);
    }
    
    
}