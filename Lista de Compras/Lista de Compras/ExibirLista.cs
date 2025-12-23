using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feira;

namespace Feira
{
    public class ExibirLista
    {
        public static void Exibir(List<string> Item)
        {
            Console.Clear();
            Console.WriteLine("*---- Lista salva ----*\n");

            if (Item.Count == 0)
                Console.WriteLine("A lista está vazia.");
            else
            {
                foreach(var item in Item)
                {
                    Console.WriteLine(Item);
                }
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Thread.Sleep(5000);
        }

    }
}
