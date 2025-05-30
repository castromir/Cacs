namespace Cacs.Domain.Models
{
    using Cacs.Domain.Models.Classe;
    using Cacs.Domain.Models.Enums;

    public class Habilidade
    {
        public string Nome { get; private set; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        public FonteHabilidade Fonte { get; }

        public ClasseBase? ClasseRequerida { get; private set; }
        public Guid? TrilhaRequeridaId { get; private set; }
        public Trilha? TrilhaRequerida { get; private set; }
        public Guid? OrigemRequeridaId { get; private set; }
        public Origem? OrigemRequerida { get; private set; }
        public Guid? PoderParanormalId { get; private set; }
        public PoderParanormal? PoderParanormal { get; private set; }
    }
}
