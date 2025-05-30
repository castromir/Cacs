namespace Cacs.Domain.Models
{
    public class Origem
    {
        public static readonly List<Pericia> Pericias = [];

        public string Nome { get; } = string.Empty;

        public string Descricao { get; } = string.Empty;

        public string Habilidade { get; } = string.Empty;

        public IReadOnlyCollection<Pericia> PericiasTreinadas { get; }

        public Origem(string nome, string descricao, IEnumerable<Pericia> periciasTreinadas, string habilidade)
        {
            if (periciasTreinadas.Count() != 2)
            {
                throw new ArgumentException("A origem deve conceder exatamente 2 pericias.", nameof(periciasTreinadas));
            }

            this.Nome = nome;
            this.Descricao = descricao;
            this.Habilidade = habilidade;
            this.PericiasTreinadas = periciasTreinadas.ToList().AsReadOnly();
        }
    }
}
