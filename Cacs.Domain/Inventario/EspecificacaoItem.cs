namespace Cacs.Domain.Inventario
{
    public sealed record EspecificacaoItem
    {
        public string Nome { get; }
        public string? Descricao { get; }
        public int Espaco { get; }
        public Categoria CategoriaBase { get; }
        public TipoItem Classificacao { get; }

        public EspecificacaoItem(
            string nome,
            string? descricao,
            int espaco,
            Categoria categoriaBase,
            TipoItem classificacao)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(nome);
            ArgumentOutOfRangeException.ThrowIfNegative(espaco);

            Nome = nome;
            Descricao = descricao;
            Espaco = espaco;
            CategoriaBase = categoriaBase;
            Classificacao = classificacao;
        }
    }
}
