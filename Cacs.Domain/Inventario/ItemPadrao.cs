using Cacs.Domain.Models.SeedWork;

namespace Cacs.Domain.Inventario
{
    public sealed class ItemPadrao : Entidade, IAggregateRoot
    {
        public EspecificacaoItem Especificacao { get; private set; }
    }
}
