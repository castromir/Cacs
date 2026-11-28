using Cacs.Domain.Inventario.Enums;

namespace Cacs.Domain.Inventario
{
    public sealed record DetalheOperacional : DetalheItem
    {
        public override TipoItem Tipo => TipoItem.Operacional;

        public DetalheOperacional()
        {
        }
    }
}
