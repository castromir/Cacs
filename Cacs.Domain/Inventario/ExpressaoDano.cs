namespace Cacs.Domain.Inventario
{
    public readonly record struct ExpressaoDano
    {
        public int Quantidade { get; }

        public int? Faces { get; }

        public int Bonus { get; }

        public ExpressaoDano(int quantidade, int? faces, int bonus)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(quantidade);

            Quantidade = quantidade;
            Faces = faces;
            Bonus = bonus;
        }
    }
}
