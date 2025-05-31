namespace Cacs.Domain.Models
{
    using Cacs.Domain.Models.Enums;

    public class Ritual
    {
        public Guid Id { get; private set; }

        public int CustoPE { get; private set; }

        public Elemento Elemento { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public int Circulo { get; private set; }
        public string Execucao { get; private set; } = string.Empty;
        public string Alcance { get; private set; } = string.Empty;
        public string Alvo { get; private set; } = string.Empty;
        public string Duracao { get; private set; } = string.Empty;
        public string Resistência { get; private set; } = string.Empty;
        public string DescricaoBase { get; private set; } = string.Empty;

        public ICollection<RitualFormaAvancada>? FormasAvancadas { get; private set; } = [];

        public Ritual()
        {

        }

        protected Ritual()
        {

        }
    }
}
