namespace Cacs.Domain.Inventario
{
    public sealed record EspecificacaoItem
    {
        protected string Nome { get; }
        protected string? Descricao { get; }
        protected int Espaco { get; }
        protected Categoria CategoriaBase { get; }
        protected TipoItem Classificacao { get; }

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
