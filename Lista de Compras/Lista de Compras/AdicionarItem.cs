using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feira;

namespace Feira
{
    public class Execute 
    {
        private string Name { get; set; }
        private int UnitAmount { get; set; }
        private decimal Price { get; set; }

        public void Executar(List<string> Item) 
        {
            string continuar;
            do{
                Console.Clear();

                Console.WriteLine("*---- Adicionando um novo item ----*");

                Console.Write("Nome do item: ");
                Name = Console.ReadLine();

                Console.Write("Quantidade: ");
                int.TryParse(Console.ReadLine(), out int amount);
                UnitAmount = amount;

                Console.Write("Valor: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal value))
                {
                    Price = value;
                    decimal subtotal = UnitAmount * Price;

                    Item.Add($"{Name.PadRight(0)}\nQtd: {UnitAmount} | Preço: {Price:C2} | Subtotal: {subtotal:C2}");

                    Console.WriteLine($"\nItem adicionado!\nSubtotal: {subtotal:C2}");
                }
                else 
                {
                    Console.WriteLine("\n❌ Valor inválido! O item não foi salvo.");
                }
                
                Console.Write("\nDeseja adicionar outro item? (s/n): ");
                continuar = Console.ReadLine().ToLower();

            } while(continuar == "s");
        }
    }
}
