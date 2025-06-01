namespace Cacs.Domain.Models
{
    using Cacs.Domain.Models.Enums;

    public class Pericia
    {
        public int Id { get; set; }

        public NomePericia NomePericia { get; }

        public NivelTreinamento NivelTreinamento { get; private set; }

        public int OutrosBonus { get; private set; }

        public int FichaId { get; set; }

        public Pericia(NomePericia nomePericia)
        {
            this.NomePericia = nomePericia;
            this.NivelTreinamento = new NivelTreinamento(Treinamento.Destreinado);
            this.OutrosBonus = 0;
        }

        public void DefinirNivel(Treinamento novoTreinamento)
        {
            this.NivelTreinamento = new NivelTreinamento(novoTreinamento);
        }

        public void DefinirOutrosBonus(int bonus)
        {
            this.OutrosBonus = bonus;
        }
    }
}
