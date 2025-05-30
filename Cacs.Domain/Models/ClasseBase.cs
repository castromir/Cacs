// <copyright file="ClasseBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Cacs.Domain.Models
{
    /// <summary>
    /// Representa a classe base para todos os personagens.
    /// </summary>
    public abstract class ClasseBase
    {
        protected int PontosVidaInicial { get; set; }

        protected int PontosEsforcoInicial { get; set; }

        protected int SanidadeInicial { get; set; }

        protected int BonusPontosVida { get; set; }

        protected int BonusPontosEsforco { get; set; }

        protected int BonusSanidade { get; set; }

        public abstract void CalcularAtributos();

        public int CalcularPontosVida(int nex)
            => this.PontosVidaInicial + (this.BonusPontosVida * nex / 5);

        public int CalcularPontosEsforco(int nex)
            => this.PontosEsforcoInicial + (this.BonusPontosEsforco * nex / 5);

        public int CalcularSanidade(int nex)
            => this.SanidadeInicial + (this.BonusSanidade * nex / 5);
    }
}
