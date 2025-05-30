namespace Cacs.Domain.Models
{
    public class Especialista : ClasseBase
    {
        public override void CalcularAtributos()
        {
            this.PontosVidaInicial = 16;
            this.PontosEsforcoInicial = 3;
            this.SanidadeInicial = 16;

            this.BonusPontosVida = 3;
            this.BonusPontosEsforco = 3;
            this.BonusSanidade = 4;
        }
    }
}
