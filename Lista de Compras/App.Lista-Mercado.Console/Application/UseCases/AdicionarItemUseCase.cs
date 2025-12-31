using App.Lista_Mercado.Domain.Entidades;

namespace App.Lista_Mercado.Application.UseCases
{
    public class AdicionarItemUseCase
    {
        public void Adicionar(ListaCompra listaCompra, Item item)
        {
			try
			{
                listaCompra.AdicionarItem(item);
			}
			catch (Exception ex)
			{
                Console.WriteLine($"Erro ao adicionar na lista de compras: {ex}");
                throw;
			}
        }
    }
}
