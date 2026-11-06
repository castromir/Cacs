namespace Cacs.Domain.Inventario
{
    public sealed record EspecificacaoItem(
        string Nome,
        string Descricao,
        int Espaco,
        Categoria CategoriaBase,
        TipoItem Classificacao
        );
}
