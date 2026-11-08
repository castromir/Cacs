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

        private DetalheMunicao(
            TipoMunicao tipoMunicao,
            int capacidadeMunicao)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(capacidadeMunicao);

            TipoMunicao = tipoMunicao;
            CapacidadeMunicao = capacidadeMunicao;
            MunicaoUtilizada = 0;
        }

        // averiguar (e criar, caso válido) construtor para restauração TODO
    }
}
