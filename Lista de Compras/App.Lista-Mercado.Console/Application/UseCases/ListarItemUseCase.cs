using App.Lista_Mercado.Domain.Entidades;

namespace App.Lista_Mercado.Application.UseCases
{
    public class ListarItemUseCase
    {
        public void Listar(ListaCompra listaCompra, string id)
        {
            try
            {
                listaCompra.ListarItem(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar na lista de compras: {ex}");
                throw;
            }
        }
    }
}
