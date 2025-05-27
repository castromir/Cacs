namespace CacsShared.Models
{
    public class Especialista : ClasseBase
    {
        public override void CalcularAtributos()
        {
            PontosVidaInicial = 16;
            PontosEsforcoInicial = 3;
            SanidadeInicial = 16;

            BonusPontosVida = 3;
            BonusPontosEsforco = 3;
            BonusSanidade = 4;
        }
    }
}
