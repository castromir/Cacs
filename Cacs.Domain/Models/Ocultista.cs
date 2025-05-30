namespace Cacs.Domain.Models
{
    public class Ocultista : ClasseBase
    {
        public override void CalcularAtributos()
        {
            this.PontosVidaInicial = 12;
            this.PontosEsforcoInicial = 4;
            this.SanidadeInicial = 20;

            this.BonusPontosVida = 2;
            this.BonusPontosEsforco = 4;
            this.BonusSanidade = 5;
        }
    }
}
