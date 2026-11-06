namespace Cacs.Domain.Inventario
{
    public readonly record struct Categoria
    {
        public CategoriaNivel Nivel { get; }

        public int Custo => (int)Nivel;

        public Categoria(CategoriaNivel nivel)
        {
            if (!Enum.IsDefined(nivel))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(nivel),
                    "A categoria informada é inválida.");
            }

            Nivel = nivel;
        }
    }
}
