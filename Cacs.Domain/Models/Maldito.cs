namespace CacsShared.Models
{
    public class Maldito : ClasseBase
    {
        public override void CalcularAtributos()
        {
            PontosVidaInicial = 14;
            PontosEsforcoInicial = 3;
            SanidadeInicial = 14;

            BonusPontosVida = 3;
            BonusPontosEsforco = 2;
            BonusSanidade = 4;
        }
    }
}
