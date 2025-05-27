namespace CacsShared.Models
{
    public abstract class ClasseBase
    {
        protected int PontosVidaInicial { get; set; }
        protected int PontosEsforcoInicial { get; set; }
        protected int SanidadeInicial { get; set; }

        protected int BonusPontosVida { get; set; }
        protected int BonusPontosEsforco { get; set; }
        protected int BonusSanidade { get; set; }

        public abstract void CalcularAtributos();

        public int CalcularPontosVida(int nex) => PontosVidaInicial + BonusPontosVida * (nex - 5) / 5;
        public int CalcularPontosEsforco(int nex) => PontosEsforcoInicial + BonusPontosEsforco * (nex - 5) / 5;
        public int CalcularSanidade(int nex) => SanidadeInicial + BonusSanidade * (nex - 5) / 5;
    }
}
