namespace Cacs.Domain.Models.Itens
{
    using Cacs.Domain.Models.Enums;

    public class Arma : Item
    {
        public TipoArma TipoArma { get; private set; }
        public TipoDano TipoDano { get; private set; }

        public Arma(
            string nome,
            string descricao,
            int espaco,
            int categoria,
            Proficiencia proficiencia,
            TipoArma tipoArma,
            TipoDano tipoDano)
            : base(nome, descricao, espaco, categoria, proficiencia)
        {
            this.TipoArma = tipoArma;
            this.TipoDano = tipoDano;
        }
    }
}
