namespace Cacs.Domain.Models
{
    public class Combatente : ClasseBase
    {
        public override void CalcularAtributos()
        {
            this.PontosVidaInicial = 20;
            this.PontosEsforcoInicial = 2;
            this.SanidadeInicial = 14;

            this.BonusPontosVida = 4;
            this.BonusPontosEsforco = 2;
            this.BonusSanidade = 3;
        }
    }
}
