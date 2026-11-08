using Cacs.Domain.Inventario.Enums;

namespace Cacs.Domain.Inventario
{
    public abstract record DetalheItem
    {
        public abstract TipoItem Tipo { get; }
    }
}
