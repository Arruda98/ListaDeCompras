using App.Lista_Mercado.Domain.Entidades;

namespace App.Lista_Mercado.Application.UseCases
{
    public class RemoverItemUseCase
    {
        public void Remover(ListaCompra listaCompra, string id)
        {
            try
            {
                listaCompra.RemoverItem(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar na lista de compras: {ex}");
                throw;
            }
        }
    }
}
