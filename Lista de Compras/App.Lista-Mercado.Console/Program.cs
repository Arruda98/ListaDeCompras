using App.Lista_Mercado.Application.UseCases;
using App.Lista_Mercado.Domain.Entidades;

namespace App.Lista_Mercado
{
    public class Program
    {
        public static AdicionarItemUseCase adicionarItemUseCase = new AdicionarItemUseCase();
        public static ListarItensUseCase listarItensUseCase = new ListarItensUseCase();
        public static ListarItemUseCase listarItemUseCase = new ListarItemUseCase();
        public static AtualizarItemUseCase atualizarItemUseCase = new AtualizarItemUseCase();
        public static RemoverItemUseCase removerItemUseCase = new RemoverItemUseCase();
        public static ListaCompra ListaCompras = new ListaCompra() { Id = Guid.NewGuid().ToString("N").Substring(0, 6), Titulo = "Compras do mercado" };

        public static void Main(string[] args)
        {
            bool executando = true;
            while (executando)
            {
                executando = Menu();
            }
        }
        public static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("*--- Lista de Compras ---*");
            Console.WriteLine("\nSelecione o que deseja fazer: ");
            Console.WriteLine("1 - Adicionar Item;" +
                "\n2 - Remover Item;" +
                "\n3 - Exibir Lista;" +
                "\n4 - Exibir Item;" +
                "\n5 - Atualizar Item;" +
                "\n6 - Sair.");



            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Entrada inválida! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return true;
            }

            if (choice == 6)
                return false;

            switch (choice)
            {
                case 1:
                    AdicionarNovoItem();
                    break;
                case 2:
                    RemoverItemLista();
                    break;
                case 3:
                    ListarItensLista();
                    break;
                case 4:
                    ListarItemLista();
                    break;
                case 5:
                    AtualizarItemLista();
                    break;
                default: Console.WriteLine("Opção invalida!"); break;
            }
            return true;
        }

        public static void AdicionarNovoItem()
        {
            string continuar;
            do
            {
                Console.Clear();

                Console.WriteLine("*---- Adicionando um novo item ----*");

                Console.Write("Nome do item: ");
                var Name = Console.ReadLine();

                Console.Write("Quantidade: ");
                int.TryParse(Console.ReadLine(), out int amount);
                var UnitAmount = amount;

                Console.Write("Valor: ");
                decimal.TryParse(Console.ReadLine(), out decimal value);
                var Price = value;

                adicionarItemUseCase.Adicionar(ListaCompras, new Item()
                {
                    Id = Guid.NewGuid().ToString("N").Substring(0, 6),
                    Nome = Name,
                    Quantidade = UnitAmount,
                    ValorUnitario = Price
                });

                Console.WriteLine("Item adicionado com sucesso");

                Console.Write("\nDeseja adicionar outro item? (s/n): ");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");
        }

        public static void ListarItensLista()
        {
            listarItensUseCase.Listar(ListaCompras);
            Thread.Sleep(4000);
        }

        public static void ListarItemLista()
        {
            Console.Clear();
            Console.WriteLine("Informe o ID do item que você deseja listar.");
            var id = Console.ReadLine();
            listarItemUseCase.Listar(ListaCompras, id);
            Thread.Sleep(4000);
        }

        public static void AtualizarItemLista()
        {
            Console.Clear();
            Console.WriteLine("Informe o ID do item que você deseja atualizar.");
            var id = Console.ReadLine();

            Console.WriteLine("Informe os novos dados do item.");

            Console.Write("Nome do item: ");
            var Name = Console.ReadLine();

            Console.Write("Quantidade: ");
            int.TryParse(Console.ReadLine(), out int amount);
            var UnitAmount = amount;

            Console.Write("Valor: ");
            decimal.TryParse(Console.ReadLine(), out decimal value);
            var Price = value;

            var newItem = new Item()
            {
                Nome = Name,
                Quantidade = UnitAmount,
                ValorUnitario = Price
            };

            atualizarItemUseCase.Atualizar(ListaCompras, newItem, id);
            Thread.Sleep(2000);
        }

        public static void RemoverItemLista()
        {
            Console.Clear();
            Console.WriteLine("Informe o ID do item que você deseja remover.");
            var id = Console.ReadLine();
            removerItemUseCase.Remover(ListaCompras, id);
            Thread.Sleep(2000);
        }
    }
}