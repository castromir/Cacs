namespace Cacs.Domain.Models
{
    using Cacs.Domain.Models.Enums;

    public class Ritual
    {
        public Guid Id { get; private set; }

        public int CustoPE { get; private set; }

        public Elemento Elemento { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public int Circulo { get; private set; }
        public string Execucao { get; private set; } = string.Empty;
        public string Alcance { get; private set; } = string.Empty;
        public string Alvo { get; private set; } = string.Empty;
        public string Duracao { get; private set; } = string.Empty;
        public string Resistência { get; private set; } = string.Empty;
        public string DescricaoBase { get; private set; } = string.Empty;

        public ICollection<RitualFormaAvancada>? FormasAvancadas { get; private set; } = [];

        public Ritual(
            int custoPE,
            Elemento elemento,
            string nome,
            int circulo,
            string execucao,
            string alcance,
            string alvo,
            string duracao,
            string resistência,
            string descricaoBase,
            ICollection<RitualFormaAvancada>? formasAvancadas)
        {
            this.CustoPE = custoPE;
            this.Elemento = elemento;
            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.Circulo = circulo;
            this.Execucao = execucao ?? throw new ArgumentNullException(nameof(execucao));
            this.Alcance = alcance ?? throw new ArgumentNullException(nameof(alcance));
            this.Alvo = alvo ?? throw new ArgumentNullException(nameof(alvo));
            this.Duracao = duracao ?? throw new ArgumentNullException(nameof(duracao));
            this.Resistência = resistência ?? throw new ArgumentNullException(nameof(resistência));
            this.DescricaoBase = descricaoBase ?? throw new ArgumentNullException(nameof(descricaoBase));
            this.FormasAvancadas = formasAvancadas;
        }

        protected Ritual()
        {
        }

        public void DefinirCustoPE(int custoPE)
        {
            if (custoPE < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(custoPE), "Custo de PE nao pode ser menor que 1.");
            }

            this.CustoPE = custoPE;
        }

        public void DefinirElemento(Elemento elemento)
        {
            this.Elemento = elemento;
        }

        public void DefinirNome(string nome)
        {
            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }

        public void DefinirCirculo(int circulo)
        {
            if (circulo < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(circulo), "Circulo nao pode ser menor que 1.");
            }

            this.Circulo = circulo;
        }

        public void DefinirExecucao(string execucao)
        {
            this.Execucao = execucao ?? throw new ArgumentNullException(nameof(execucao));
        }

        public void DefinirAlcance(string alcance)
        {
            this.Alcance = alcance ?? throw new ArgumentNullException(nameof(alcance));
        }

        public void DefinirAlvo(string alvo)
        {
            this.Alvo = alvo ?? throw new ArgumentNullException(nameof(alvo));
        }

        public void DefinirDuracao(string duracao)
        {
            this.Duracao = duracao ?? throw new ArgumentNullException(nameof(duracao));
        }

        public void DefinirResistencia(string resistencia)
        {
            this.Resistência = resistencia ?? throw new ArgumentNullException(nameof(resistencia));
        }

        public void DefinirDescricaoBase(string descricaoBase)
        {
            this.DescricaoBase = descricaoBase ?? throw new ArgumentNullException(nameof(descricaoBase));
        }
    }
}
