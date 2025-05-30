namespace Cacs.Domain.Models
{
    public class Pericia(string nome, NivelDeTreinamento nivelTreinamento)
    {
        public int Id { get; set; }

        public string Nome { get; } = nome;

        public NivelDeTreinamento NivelTreinamento { get; } = nivelTreinamento;

        public int OutrosBonus { get; set; }

        public int FichaId { get; set; }
    }
}
