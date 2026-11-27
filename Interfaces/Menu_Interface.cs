
namespace SistemaDeEmprestimo.Interfaces
{
    public class MenuConsole
    {
        public void Executar()
        {
            bool executando = true;

            while (executando)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("   SISTEMA DE EMPRÉSTIMOS");
                Console.WriteLine("==============================");
                Console.WriteLine("1 - Usuários");
                Console.WriteLine("2 - Equipamentos");
                Console.WriteLine("3 - Empréstimos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("==============================");

                Console.Write("Escolha uma opção: ");
                string? entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "1":
                        Console.WriteLine("Menu de usuários");
                        break;

                    case "2":
                        Console.WriteLine("Menu de equipamentos");
                        break;

                    case "3":
                        Console.WriteLine("Menu de empréstimos");
                        break;

                    case "0":
                        executando = false;
                        Console.WriteLine("Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
