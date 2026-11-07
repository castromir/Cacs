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

        private ItemInventario(
            int quantidade,
            EspecificacaoItem especificacao
            )
        {
            Especificacao = especificacao;
            Quantidade = quantidade;
        }

        public static ItemInventario Criar(
            int quantidade,
            EspecificacaoItem especificacao
            )
        {
            ArgumentNullException.ThrowIfNull(especificacao);

            if (quantidade <= 0)
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(quantidade);
            }

            return new ItemInventario(quantidade, especificacao);
        }
    }
}
