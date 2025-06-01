namespace Cacs.Domain.Models.Enums
{
    /// <summary>
    /// Representa os tipos de dano possiveis no sistema.
    /// </summary>
    public enum TipoDano
    {
        /// <summary> Dano causado por arma balistica (projeteis, balas). </summary>
        Balistico,

        /// <summary> Dano causado por armas de Conhecimento. </summary>
        Conhecimento,

        /// <summary> Dano causado por armas de corte (facas, espadas). </summary>
        Corte,

        /// <summary> Dano causado por eletricidade. </summary>
        Eletricidade,

        /// <summary> Dano causado por armas de Energia. </summary>
        Energia,

        /// <summary> Dano causado por fogo. </summary>
        Fogo,

        /// <summary> Dano causado por frio ou congelamento. </summary>
        Frio,

        /// <summary> Dano causado por impacto fisico (quedas, socos, bastao). </summary>
        Impacto,

        /// <summary> Dano causado por ataques mentais (criaturas, etc). </summary>
        Mental,

        /// <summary> Dano causado por Medo (dano verdadeiro). </summary>
        Medo,

        /// <summary> Dano causado por Morte. </summary>
        Morte,

        /// <summary> Dano causado por perfuracao (flechas, lancas). </summary>
        Perfuracao,

        /// <summary> Dano causado por Sangue. </summary>
        Sangue,

        /// <summary> Dano causado por agentes quimicos. </summary>
        Quimico,
    }
}
