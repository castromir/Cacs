namespace Cacs.Domain.Inventario
{
    public readonly record struct PontosCategoria
    {
        public Categoria Categoria { get; }

        public int Quantidade { get; }

        public int Pontos => Categoria.Custo * Quantidade;

        public PontosCategoria(Categoria categoria, int quantidade)
        {
            if (quantidade < 0)
                throw new ArgumentOutOfRangeException(nameof(quantidade));

            Categoria = categoria;
            Quantidade = quantidade;
        }
    }
}
