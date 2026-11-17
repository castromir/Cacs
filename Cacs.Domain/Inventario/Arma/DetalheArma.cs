using Cacs.Domain.Inventario.Enums;

namespace Cacs.Domain.Inventario.Arma
{
    public sealed record DetalheArma : DetalheItem
    {
        public Alcance Alcance { get; }

        public Dominio Dominio { get; }

        public Empunhadura Empunhadura { get; }

        public TipoArma TipoArma { get; }

        public TipoDano TipoDano { get; }

        public IReadOnlyCollection<Traco> Tracos { get; }

        public override TipoItem Tipo => TipoItem.Arma;

        public DetalheArma(
            Alcance alcance,
            Dominio dominio,
            Empunhadura empunhadura,
            TipoArma tipoArma,
            TipoDano tipoDano,
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

            if (!Enum.IsDefined(tipoDano))
                throw new ArgumentOutOfRangeException(nameof(tipoDano));

            if (tracos.Any(t => string.IsNullOrWhiteSpace(t.Descricao) || !Enum.IsDefined(t.Tipo)))
                throw new ArgumentException("A arma não pode conter um traço inválido.", nameof(tracos));

            Alcance = alcance;
            Dominio = dominio;
            Empunhadura = empunhadura;
            TipoArma = tipoArma;
            TipoDano = tipoDano;
            Tracos = Array.AsReadOnly(tracos.ToArray());
        }
    }
}
