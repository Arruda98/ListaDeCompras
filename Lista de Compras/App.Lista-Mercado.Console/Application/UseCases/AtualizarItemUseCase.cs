using App.Lista_Mercado.Domain.Entidades;

namespace App.Lista_Mercado.Application.UseCases
{
    public class AtualizarItemUseCase
    {
        public void Atualizar(ListaCompra listaCompra, Item newItem, string id)
        {
            try
            {
                listaCompra.AtualizarItem(newItem, id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar na lista de compras: {ex}");
                throw;
            }
        }
    }
}
