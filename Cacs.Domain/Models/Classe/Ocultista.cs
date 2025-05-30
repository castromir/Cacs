namespace Cacs.Domain.Models.Classe
{
    public class Ocultista : ClasseBase
    {
        public Ocultista()
        {
            this.PontosVidaInicial = 12;
            this.PontosEsforcoInicial = 4;
            this.SanidadeInicial = 20;

            this.BonusPontosVida = 2;
            this.BonusPontosEsforco = 4;
            this.BonusSanidade = 5;
        }

        public override void CalcularAtributos()
        {
        }
    }
}
