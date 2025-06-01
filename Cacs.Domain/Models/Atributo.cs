namespace Cacs.Domain.Models
{
    using Cacs.Domain.Models.Enums;

    public class Atributo
    {
        public NomeAtributo NomeAtributo { get; }
        public int Valor { get; private set; }

        public Atributo(NomeAtributo nomeAtributo)
        {
            this.NomeAtributo = nomeAtributo;
            this.Valor = 1;
        }

        public void Modificar(int modificador)
        {
            this.Valor += modificador;
        }
    }
}
