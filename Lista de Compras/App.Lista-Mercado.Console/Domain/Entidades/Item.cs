namespace App.Lista_Mercado.Domain.Entidades
{
    public class Item
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal => ValorUnitario * Quantidade;

        public void Update(Item newItem)
        {
            if (!string.IsNullOrEmpty(newItem.Nome))
                Nome = newItem.Nome;

            if (newItem.Quantidade > 0 && newItem.Quantidade != Quantidade)
                Quantidade = newItem.Quantidade;

            if (newItem.ValorUnitario > 0 && newItem.ValorUnitario != ValorUnitario)
                ValorUnitario = newItem.ValorUnitario;
        }
    }
}
