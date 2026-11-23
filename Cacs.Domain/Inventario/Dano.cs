using Cacs.Domain.Inventario.Arma;

namespace Cacs.Domain.Inventario
{
    public readonly record struct Dano
    {
        public ExpressaoDano Expressao { get; }

        public TipoDano Tipo { get; }

        public Dano(ExpressaoDano expressao, TipoDano tipo)
        {
            if (!Enum.IsDefined(tipo))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(tipo),
                    "O tipo de dano informado é inválido.");
            }

            Expressao = expressao;
            Tipo = tipo;
        }
    }
}
