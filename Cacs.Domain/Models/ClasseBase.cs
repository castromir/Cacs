namespace CacsShared.Models
{
    /// <summary>
    /// Representa a classe base para todos os personagens.
    /// </summary>
    public abstract class ClasseBase
    {
        /// <summary>
        /// Gets or sets pontos de Vida antes de bonus por NEX.
        /// </summary>
        protected int PontosVidaInicial { get; set; }

        /// <summary>
        /// Gets or sets pontos de esforco antes de bonus por NEX.
        /// </summary>
        protected int PontosEsforcoInicial { get; set; }

        /// <summary>
        /// Gets or sets sanidade antes de bonus por NEX.
        /// </summary>
        protected int SanidadeInicial { get; set; }

        /// <summary>
        /// Gets or sets pontos de vida bonus por classe.
        /// </summary>
        protected int BonusPontosVida { get; set; }

        /// <summary>
        /// Gets or sets pontos de esforco bonus por classe.
        /// </summary>
        protected int BonusPontosEsforco { get; set; }

        /// <summary>
        /// Gets or sets sanidade bonus por classe.
        /// </summary>
        protected int BonusSanidade { get; set; }

        /// <summary>
        /// Calcula os atributos da classe derivada.
        /// </summary>
        public abstract void CalcularAtributos();

        /// <summary>
        /// Calcula os Pontos de Vida da classe derivada.
        /// </summary>
        /// <returns>
        /// Retorna os Pontos de Vida totais da classe derivada.
        /// </returns>
        public int CalcularPontosVida(int nex)
            => this.PontosVidaInicial + (this.BonusPontosVida * nex / 5);

        /// <summary>
        /// Calcula os Pontos de Esforço da classe derivada.
        /// </summary>
        /// /// <returns>
        /// Retorna os Pontos de Esforco totais da classe derivada.
        /// </returns>
        public int CalcularPontosEsforco(int nex)
            => PontosEsforcoInicial + (BonusPontosEsforco * nex / 5);

        /// <summary>
        /// Calcula a Sanidade da classe derivada.
        /// </summary>
        /// <returns>
        /// Retorna a Sanidade total da classe derivada.
        /// </returns>
        public int CalcularSanidade(int nex)
            => SanidadeInicial + (BonusSanidade * nex / 5);
    }
}
