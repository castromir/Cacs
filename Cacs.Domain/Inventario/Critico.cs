namespace Cacs.Domain.Inventario
{
    public readonly record struct Critico
    {
        public int Margem { get; }

        public int Multiplicador { get; }

        public Critico(int margem, int multiplicador)
        {
            if (margem is < 0 or > 20)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(margem),
                    "A margem de acerto crítico deve ser maior que 0 e menor que 21.");
            }

            if (multiplicador is < 2)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(multiplicador),
                    "O multiplicador de acerto crítico deve ser 2 ou maior.");
            }
        }
    }
}
