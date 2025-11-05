namespace Cacs.Domain.Models.Itens
{
    using Cacs.Domain.Models.Enums;

    public class Protecao : Item
    {
        public int Defesa { get; private set; }

        public Protecao(
            string nome,
            string descricao,
            int espaco,
            int categoria,
            Proficiencia proficiencia,
            int defesa)
            : base(nome, descricao, espaco, categoria, proficiencia)
        {
            this.Defesa = defesa;
        }
    }
}
