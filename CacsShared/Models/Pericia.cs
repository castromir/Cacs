namespace CacsShared.Models
{
    public enum NivelTreinamento
    {
        Nenhum = 0,
        Treinado = 2,
        Veterano = 4,
        Expert = 6
    }

    public class Pericia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public NivelTreinamento Nivel { get; set; } = NivelTreinamento.Nenhum;
        public int FichaId { get; set; }
        public int Valor { get; set; }
    }
}