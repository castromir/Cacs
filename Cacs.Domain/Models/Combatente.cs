namespace CacsShared.Models
{
    public class Combatente : ClasseBase
    {
        public override void CalcularAtributos()
        {
            PontosVidaInicial = 20;
            PontosEsforcoInicial = 2;
            SanidadeInicial = 14;

            BonusPontosVida = 4;
            BonusPontosEsforco = 2;
            BonusSanidade = 3;
        }
    }
}
