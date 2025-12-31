namespace App.Lista_Mercado.Domain.Entidades
{
    public class ListaCompra
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public List<Item> Itens { get; set; }
        public decimal ValorTotal => Itens.Sum(i => i.ValorTotal);

        public ListaCompra()
        {
            Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
            Console.WriteLine("Item adicionado!!");
        }

        public void ListarItens() 
        {
            Console.WriteLine("ID - Nome - Quantidade - Valor Unitário - Valor Total");
            foreach (var item in Itens)
                Console.WriteLine($"{item.Id} - {item.Nome} - {item.Quantidade} - R${item.ValorUnitario.ToString("F2")} - R${item.ValorTotal.ToString("F2")}");
        }

        public void ListarItem(string id)
        {
            Console.WriteLine("ID - Nome - Quantidade - Valor Unitário - Valor Total");

            var item = Itens.Where(i => i.Id == id).FirstOrDefault();
            if (item is null)
            {
                Console.WriteLine("Item não encontrado.");
                throw new Exception("Item not found.");
            }
            Console.WriteLine($"{item.Id} - {item.Nome} - {item.Quantidade} - R${item.ValorUnitario.ToString("F2")} - R${item.ValorTotal.ToString("F2")}");
        }

        public void AtualizarItem(Item newItem, string id)
        {
            var item = Itens.Where(i => i.Id == id).FirstOrDefault();
            if (item is null)
            {
                Console.WriteLine("Item não foi encontrado");
                throw new Exception("Item not found.");
            }
            item.Update(newItem);
            Console.WriteLine("Item atualizado com sucesso!!");
        }

        public void RemoverItem(string id)
        {
            var item = Itens.Where(i => i.Id == id).FirstOrDefault();
            if (item is null)
            {
                Console.WriteLine("Item não foi encontrado");
                throw new Exception("Item not found.");
            }
            Itens.Remove(item);
            Console.WriteLine("Item removido com sucesso!!");
        }
    }
}
