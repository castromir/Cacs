namespace Cacs.Domain.Models.Enums
{
    public enum TipoArma
    {
        /// <summary>
        /// Uma arma que ataca alvos adjacentes, soma forca no dano e usa Luta.
        /// </summary>
        CorpoACorpo,

        /// <summary>
        /// Uma arma que ataca em alvos em alcance curto, soma forca no dano e usa Pontaria.
        /// </summary>
        Arremesso,

        /// <summary>
        /// Uma arma que ataca em alvos em até alcance médio e usa Pontaria.
        /// </summary>
        Disparo,

        /// <summary>
        /// Uma arma que ataca em alvos em até alcance extremo e usa Pontaria.
        /// </summary>
        Fogo,
    }
}
