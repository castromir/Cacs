namespace Cacs.Domain.Models
{
    using Cacs.Domain.Models.Enums;

    public class PoderParanormal
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        public string Afinidade { get; private set; } = string.Empty;
        public int Prerequisito { get; private set; }
        public Elemento Elemento { get; private set; }

        public PoderParanormal(string nome, string descricao, string afinidade, int prerequisito, Elemento elemento)
        {
            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            this.Afinidade = afinidade ?? throw new ArgumentNullException(nameof(afinidade));
            this.Prerequisito = prerequisito;
            this.Elemento = elemento;
        }

        protected PoderParanormal()
        {
        }
    }
}
