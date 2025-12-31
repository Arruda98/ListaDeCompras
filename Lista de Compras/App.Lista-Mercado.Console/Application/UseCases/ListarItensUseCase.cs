using App.Lista_Mercado.Domain.Entidades;

namespace App.Lista_Mercado.Application.UseCases
{
    public class ListarItensUseCase
    {
        public void Listar(ListaCompra listaCompra)
        {
            try
            {
                listaCompra.ListarItens();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar na lista de compras: {ex}");
                throw;
            }
        }
    }
}
