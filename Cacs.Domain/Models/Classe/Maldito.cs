namespace Cacs.Domain.Models.Classe
{
    public class Maldito : ClasseBase
    {
        public Maldito()
        {
            this.PontosVidaInicial = 14;
            this.PontosEsforcoInicial = 3;
            this.SanidadeInicial = 14;

            this.BonusPontosVida = 3;
            this.BonusPontosEsforco = 2;
            this.BonusSanidade = 4;
        }

        public override void CalcularAtributos()
        {
        }
    }
}
