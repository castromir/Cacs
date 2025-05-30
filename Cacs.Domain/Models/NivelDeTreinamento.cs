using Cacs.Domain.Models.Enums;

namespace Cacs.Domain.Models
{
    public class NivelDeTreinamento
    {
        public NivelDeTreinamento(NivelTreinamento nivelTreinamento)
        {
            this.Nivel = nivelTreinamento;
        }

        public NivelTreinamento Nivel { get; }

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
                NivelTreinamento.Destreinado => 0,
                NivelTreinamento.Treinado => 2,
                NivelTreinamento.Veterano => 4,
                NivelTreinamento.Expert => 6,
                NivelTreinamento.Mestre => 8,
                _ => throw new NotImplementedException(),
            };
        }

        public bool PodeExecutar(string acaoRequerida)
        {
            if (acaoRequerida == "Analisar Terreno")
            {
                return this.Nivel >= NivelTreinamento.Destreinado;
            }

            return true;
        }
    }
}
