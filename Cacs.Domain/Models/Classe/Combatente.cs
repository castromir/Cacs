namespace Cacs.Domain.Models.Classe
{
    public class Combatente : ClasseBase
    {
        public Combatente()
        {
            this.PontosVidaInicial = 20;
            this.PontosEsforcoInicial = 2;
            this.SanidadeInicial = 14;

            this.BonusPontosVida = 4;
            this.BonusPontosEsforco = 2;
            this.BonusSanidade = 3;
        }

        public override void CalcularAtributos()
        {
        }
    }
}
