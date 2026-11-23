using Cacs.Domain.Inventario.Arma;
using Cacs.Domain.Inventario.Enums;

namespace Cacs.Domain.Inventario
{
    public sealed record DetalheExplosivo : DetalheItem
    {
        public Alcance Alcance { get; }

        public Dano? Dano { get; }

        public override TipoItem Tipo => TipoItem.Explosivo;

        public DetalheExplosivo(Alcance alcance, Dano? dano)
        {
            if (!Enum.IsDefined(alcance))
                throw new ArgumentOutOfRangeException(nameof(alcance));

            Alcance = alcance;
            Dano = dano;
        }
    }
}
