namespace Cacs.Domain.Models
{
    using Cacs.Domain.Models.Enums;

    public class NivelTreinamento
    {
        public NivelTreinamento(Treinamento nivelTreinamento)
        {
            this.Nivel = nivelTreinamento;
        }

        public Treinamento Nivel { get; }

        /// <summary>
        /// Obtem o bonus de treinamento baseado no nivel de treinamento.
        /// </summary>
        /// <returns>
        /// Retorna o bonus de treinamento.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// Nao implementado.
        /// </exception>
        public int ObterBonus()
        {
            return this.Nivel switch
            {
                Treinamento.Destreinado => 0,
                Treinamento.Treinado => 2,
                Treinamento.Veterano => 4,
                Treinamento.Expert => 6,
                Treinamento.Mestre => 8,
                _ => throw new NotImplementedException(),
            };
        }

        public bool PodeExecutar(string acaoRequerida)
        {
            if (acaoRequerida == "Analisar Terreno")
            {
                return this.Nivel >= Treinamento.Destreinado;
            }

            return true;
        }
    }
}
