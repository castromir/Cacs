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

        public IReadOnlyCollection<Traco> Tracos;

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
            Alcance = alcance;
            Dominio = dominio;
            Empunhadura = empunhadura;
            TipoArma = tipoArma;
            TipoDano = tipoDano;
            Tracos = tracos;
        }
    }
}
