namespace Cacs.Domain.Models
{
    public class Origem
    {
        public Guid Id { get; private set; }

        public static readonly List<Pericia> Pericias = [];
        public string Nome { get; } = string.Empty;
        public string Descricao { get; } = string.Empty;
        public string Habilidade { get; } = string.Empty;
        required public IReadOnlyCollection<Pericia> PericiasTreinadas { get; init; }

        public Origem(string nome, string descricao, IEnumerable<Pericia> periciasTreinadas, string habilidade)
        {
            if (periciasTreinadas.Count() != 2)
            {
                throw new ArgumentException("A origem deve conceder exatamente 2 pericias.", nameof(periciasTreinadas));
            }

            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            this.Habilidade = habilidade ?? throw new ArgumentNullException(nameof(habilidade));
            this.PericiasTreinadas = periciasTreinadas.ToList().AsReadOnly();
        }
    }
}
