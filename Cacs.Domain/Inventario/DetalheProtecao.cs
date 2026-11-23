using Cacs.Domain.Inventario.Enums;

namespace Cacs.Domain.Inventario.Arma
{
    public sealed record DetalheProtecao : DetalheItem
    {
        public TipoProtecao TipoProtecao { get; }

        public int BonusDefesa { get; }

        public override TipoItem Tipo => TipoItem.Protecao;

        public DetalheProtecao(
            TipoProtecao tipoProtecao,
            int bonusDefesa)
        {
            if (!Enum.IsDefined(tipoProtecao))
                throw new ArgumentOutOfRangeException(nameof(tipoProtecao));

            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(bonusDefesa);

            TipoProtecao = tipoProtecao;
            BonusDefesa = bonusDefesa;   
        }
    }
}
