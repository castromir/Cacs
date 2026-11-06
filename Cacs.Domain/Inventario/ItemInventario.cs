using Cacs.Domain.Models.SeedWork;

namespace Cacs.Domain.Inventario
{
    public sealed class ItemInventario : Entidade
    {
        public EspecificacaoItem Especificacao { get; private set; }

        public int Quantidade { get; private set; }

        public int Pontos =>
            Especificacao.CategoriaBase.Custo * Quantidade;

        public int EspacoOcupado =>
            Especificacao.Espaco * Quantidade;
    }
}
