using Cacs.Domain.Inventario.Enums;

namespace Cacs.Domain.Inventario.Arma
{
    public sealed record DetalheArma : DetalheItem
    {
        public Alcance Alcance { get; }

        public Dominio Dominio { get; }

        public Empunhadura Empunhadura { get; }

        public TipoArma TipoArma { get; }

        public Dano Dano { get; }

        public Critico Critico { get; }

        public IReadOnlyCollection<Traco> Tracos { get; }

        public override TipoItem Tipo => TipoItem.Arma;

        public DetalheArma(
            Alcance alcance,
            Dominio dominio,
            Empunhadura empunhadura,
            TipoArma tipoArma,
            Dano dano,
            Critico critico,
            IReadOnlyCollection<Traco> tracos)
        {
            ArgumentNullException.ThrowIfNull(tracos);

            if (!Enum.IsDefined(alcance))
                throw new ArgumentOutOfRangeException(nameof(alcance));

            if (!Enum.IsDefined(dominio))
                throw new ArgumentOutOfRangeException(nameof(dominio));

            if (!Enum.IsDefined(empunhadura))
                throw new ArgumentOutOfRangeException(nameof(empunhadura));

            if (!Enum.IsDefined(tipoArma))
                throw new ArgumentOutOfRangeException(nameof(tipoArma));

            if (tracos.Any(t => string.IsNullOrWhiteSpace(t.Descricao) || !Enum.IsDefined(t.Tipo)))
                throw new ArgumentException("A arma não pode conter um traço inválido.", nameof(tracos));

            if (critico == default)
                throw new ArgumentException(
                    "O crítico da arma não pode ser o valor padrão.",
                    nameof(critico));

            if (dano == default)
                throw new ArgumentException(
                    "O dano da arma não pode ser o valor padrão.",
                    nameof(dano));

            Alcance = alcance;
            Dominio = dominio;
            Empunhadura = empunhadura;
            TipoArma = tipoArma;
            Dano = dano;
            Critico = critico;
            Tracos = Array.AsReadOnly(tracos.ToArray());
        }
    }
}
