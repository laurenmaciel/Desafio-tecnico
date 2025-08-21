using System;
using Zoológico_Virtual;

class Program
{
    static void Main()
    {
        int opcao = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("\n=== Zoológico Virtual ===");
            Console.WriteLine("1 - Leão");
            Console.WriteLine("2 - Macaco");
            Console.WriteLine("3 - Elefante");
            Console.WriteLine("4 - Cobra");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha um animal: ");

            
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Digite apenas números!");
                continue; 
            }

            Animal animal = null;

            switch (opcao)
            {
                case 1:
                    animal = new Leao("Leão");
                    break;
                case 2:
                    animal = new Macaco("Macaco");
                    break;
                case 3:
                    animal = new Elefante("Elefante");
                    break;
                case 4:
                    animal = new Cobra("Cobra");
                    break;
                case 5:
                    Console.WriteLine("Saindo do zoológico...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente de novo.");
                    break;
            }

            if (animal != null)
            {
                animal.EmitirSom();
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        } while (opcao != 5);
    }
}



