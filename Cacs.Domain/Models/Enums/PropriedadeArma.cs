namespace Cacs.Domain.Models.Enums
{
    [Flags]
    public enum PropriedadesArma
    {
        /// <summary>Arma sem propriedades.</summary>
        Nenhuma = 0,

        /// <summary>Arma que pode usar Luta(Agi).</summary>
        Agil = 1 << 0,

        /// <summary>Arma que pode realizar rajada.</summary>
        Automatica = 1 << 1,

        /// <summary>Arma que pode realizar coronhada.</summary>
        Coronha = 1 << 2,

        /// <summary>Arma que deve ser empunhada com duas maos.</summary>
        DuasMaos = 1 << 3,

        /// <summary>Arma que pode ser utilizada uma em cada mao.</summary>
        Leve = 1 << 4,

        /// <summary>Arma que pode ser utilizada com uma mao.</summary>
        UmaMao = 1 << 5,

        /// <summary>Arma que pode ser utilizada com uma mao ou duas.</summary>
        Versatil = 1 << 6,
    }
}
