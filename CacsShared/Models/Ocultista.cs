namespace CacsShared.Models
{
    public class Ocultista : ClasseBase
    {
        public override void CalcularAtributos()
        {
            PontosVidaInicial = 12;
            PontosEsforcoInicial = 4;
            SanidadeInicial = 20;

            BonusPontosVida = 2;
            BonusPontosEsforco = 4;
            BonusSanidade = 5;
        }
    }
}
