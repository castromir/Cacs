namespace Cacs.Domain.Inventario.Arma
{
    public readonly record struct Traco
    {
        public TipoTraco Tipo { get; }

        public string Descricao { get; }

        public Traco(TipoTraco tipo, string descricao)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(descricao);

            Tipo = tipo;
            Descricao = descricao;
        }
    }
}
