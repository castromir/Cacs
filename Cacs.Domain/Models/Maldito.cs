namespace Cacs.Domain.Models
{
    public class Maldito : ClasseBase
    {
        public override void CalcularAtributos()
        {
            this.PontosVidaInicial = 14;
            this.PontosEsforcoInicial = 3;
            this.SanidadeInicial = 14;

            this.BonusPontosVida = 3;
            this.BonusPontosEsforco = 2;
            this.BonusSanidade = 4;
        }
    }
}
