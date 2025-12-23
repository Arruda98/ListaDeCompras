using System;
using System.IO;
using Feira;


namespace Feira
{
    public class Program
    {
        static List<string> Item = new List<string>();
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
                "\n4 - Exibir Histórico;" +
                "\n5 - Salvar Arquivo;" +
                "\n6 - Sair.");



            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Entrada inválida! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return true;
            }

            switch (choice)
            {
                case 1:
                    Execute adicionar = new Execute();
                    adicionar.Executar(Item);
                    break;
                case 2:
                case 3: 
                    ExibirLista.Exibir(Item);
                    break;
                case 4:
                case 5:
                    SalvarLista.Salvar(Item);
                    break;
                default: Console.WriteLine("Opção invalida!"); break;
            }
            return true;
        }

        

        public static void RemoverItem()
        {

            Console.Clear();

            Menu();
        }
    }
}