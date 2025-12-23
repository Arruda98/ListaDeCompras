using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Feira
{
    public class SalvarLista
    {
        public static void Salvar(List<string> Item) 
        {
            string nomeArquivo = "ListaDeCompras.txt";
            
            try
            {
                // Escreve todo o conteúdo da ListaCompras no arquivo
                File.WriteAllLines(nomeArquivo, Item);

                // Pega o caminho completo para mostrar ao usuário onde o arquivo está
                string caminhoCompleto = Path.GetFullPath(nomeArquivo);

                Console.WriteLine("\nArquivo salvo com sucesso!");
                Console.WriteLine($"Caminho: {caminhoCompleto}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro ao salvar arquivo: {ex.Message}");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
