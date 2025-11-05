namespace Cacs.Domain.Models
{
    public class RitualFormaAvancada
    {
        public Guid Id { get; private set; }
        public string Nivel { get; private set; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        public int CustoPE { get; private set; }

        public RitualFormaAvancada(string nivel, string descricao, int custoPE)
        {
            this.Nivel = nivel ?? throw new ArgumentNullException(nameof(nivel));
            this.Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            this.CustoPE = custoPE;
        }

        protected RitualFormaAvancada()
        {
        }

        public void DefinirNivel(string nivel)
        {
            if (string.IsNullOrWhiteSpace(nivel))
            {
                throw new ArgumentException("Nivel nao pode ser vazio ou nulo.", nameof(nivel));
            }

            this.Nivel = nivel;
        }

        public void DefinirDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                throw new ArgumentException("Descricao nao pode ser vazia ou nula.", nameof(descricao));
            }

            this.Descricao = descricao;
        }

        public void DefinirCustoPE(int custoPE)
        {
            if (custoPE < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(custoPE), "Custo de PE nao pode ser menor que 1.");
            }

            this.CustoPE = custoPE;
        }
    }
}
