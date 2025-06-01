namespace Cacs.Domain.Models.Enums
{
    /// <summary>
    ///     Representa os 5 possiveis niveis de treinamento do personagem em uma pericia.
    /// </summary>
    public enum Treinamento
    {
        /// <summary>
        /// Nivel padrao de treinamento.
        /// </summary>
        Destreinado = 0,

        /// <summary>
        /// Nivel 1 de treinamento.
        /// </summary>
        Treinado = 2,

        /// <summary>
        /// Nivel 2 de treinamento.
        /// </summary>
        Veterano = 4,

        /// <summary>
        /// Nivel 3 de treinamento.
        /// </summary>
        Expert = 6,

        /// <summary>
        /// Nivel 4 de treinamento.
        /// </summary>
        Mestre = 8,
    }
}
