namespace Cacs.Domain.Models.Classe
{
    public class Trilha
    {
        public Guid Id { get; private set; }
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        public List<Habilidade> Habilidades { get; init; }
    }
}
