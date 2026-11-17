using Cacs.Domain.Inventario.Enums;

namespace Cacs.Domain.Inventario
{
    public sealed record CaracteristicaComumItem
    {
        public string Nome { get; }
        public string? Descricao { get; }
        public int Espaco { get; }
        public Categoria CategoriaBase { get; }
        public DetalheItem Detalhe { get; }

        public CaracteristicaComumItem(
            string nome,
            string? descricao,
            int espaco,
            Categoria categoriaBase,
            DetalheItem detalhe)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(nome);
            ArgumentOutOfRangeException.ThrowIfNegative(espaco);
            ArgumentNullException.ThrowIfNull(detalhe);

            Nome = nome;
            Descricao = descricao;
            Espaco = espaco;
            CategoriaBase = categoriaBase;
            Detalhe = detalhe;
        }
    }
}
