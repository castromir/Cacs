namespace Cacs.Domain.Models.Classe
{
    public class Trilha
    {
        public Guid Id { get; private set; }
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        required public IReadOnlyCollection<Habilidade> Habilidades { get; init; }

        public Trilha(string nome, string descricao, List<Habilidade> habilidades)
        {
            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            this.Habilidades = habilidades ?? throw new ArgumentNullException(nameof(habilidades));
            this.Habilidades = habilidades.ToList().AsReadOnly();
        }

        protected Trilha()
        {
        }
    }
}
