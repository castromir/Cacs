using Cacs.Domain.Inventario.Enums;

namespace Cacs.Domain.Inventario
{
    public sealed record DetalheAcessorio: DetalheItem
    {
        public /*Pericia*/ string Pericia { get; } //TODO Pericia

        public int Bonus { get; }

        public override TipoItem Tipo => TipoItem.Acessorio;

        public DetalheAcessorio(
            string pericia,
            int bonus)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(pericia);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(bonus);

            Pericia = pericia;
            Bonus = bonus;
        }
    }
}
