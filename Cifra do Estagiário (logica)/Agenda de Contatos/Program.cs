using Agenda_de_Contatos;

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        int opcao;

        do
        {
            Console.WriteLine("\n=== Agenda de Contatos ===");
            Console.WriteLine("1 - Adicionar contato");
            Console.WriteLine("2 - Listar contatos");
            Console.WriteLine("3 - Buscar contato por nome");
            Console.WriteLine("4 - Remover contato");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Digite um número válido!");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Telefone: ");
                    string telefoneString = Console.ReadLine(); 
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    if (int.TryParse(telefoneString, out int telefoneInt))
                    {
                        // Se a conversão for bem-sucedida, adiciona o contato
                        agenda.AdicionarContato(new Contato(nome, telefoneInt, email));
                    }
                    else
                    {
                        Console.WriteLine("Telefone inválido. Por favor, digite apenas números.");
                    }
                    break;

                case 2:
                    agenda.ListarContato();
                    break;

                case 3:
                    Console.Write("Digite o nome para buscar: ");
                    string busca = Console.ReadLine();
                    agenda.BuscarPorNome(busca);
                    break;

                case 4:
                    Console.Write("Digite o nome do contato para remover: ");
                    string remover = Console.ReadLine();
                    agenda.RemoverContato(remover);
                    break;

                case 5:
                    Console.WriteLine("Saindo da agenda...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 5);
    }
}
