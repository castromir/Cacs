using Cacs.Domain.Inventario.Enums;

namespace Cacs.Domain.Inventario.Arma
{
    public sealed record DetalheMunicao : DetalheItem
    {
        public TipoMunicao TipoMunicao { get; }

        public int CapacidadeMunicao { get; }

        public int MunicaoUtilizada { get; }

        public int MunicaoDisponivel =>
            CapacidadeMunicao - MunicaoUtilizada;

        public override TipoItem Tipo => TipoItem.Municao;

        public static DetalheMunicao Criar(
            TipoMunicao tipoMunicao,
            int capacidadeMunicao)
            => new(tipoMunicao, capacidadeMunicao, 0);

        public static DetalheMunicao Restaurar(
            TipoMunicao tipoMunicao,
            int capacidadeMunicao,
            int municaoUtilizada)
            => new(tipoMunicao, capacidadeMunicao, municaoUtilizada);

        private DetalheMunicao(
            TipoMunicao tipoMunicao,
            int capacidadeMunicao,
            int municaoUtilizada)
        {
            if (!Enum.IsDefined(tipoMunicao))
                throw new ArgumentOutOfRangeException(nameof(tipoMunicao));

            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(capacidadeMunicao);
            ArgumentOutOfRangeException.ThrowIfNegative(municaoUtilizada);

            if (municaoUtilizada > capacidadeMunicao)
                throw new ArgumentOutOfRangeException(nameof(municaoUtilizada));

            TipoMunicao = tipoMunicao;
            CapacidadeMunicao = capacidadeMunicao;
            MunicaoUtilizada = municaoUtilizada;
        }
    }
}
