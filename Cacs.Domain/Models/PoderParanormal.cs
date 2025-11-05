namespace Cacs.Domain.Models
{
    using Cacs.Domain.Models.Enums;

    public class PoderParanormal
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        public string Afinidade { get; private set; } = string.Empty;
        public int Prerequisito { get; private set; }
        public Elemento Elemento { get; private set; }

        public PoderParanormal(string nome, string descricao, string afinidade, int prerequisito, Elemento elemento)
        {
            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            this.Afinidade = afinidade ?? throw new ArgumentNullException(nameof(afinidade));
            this.Prerequisito = prerequisito;
            this.Elemento = elemento;
        }

        protected PoderParanormal()
        {
        }

        public void DefinirNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome não pode ser vazio.", nameof(nome));
            }

            this.Nome = nome;
        }

        public void DefinirDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                throw new ArgumentException("A descrição não pode ser vazia.", nameof(descricao));
            }

            this.Descricao = descricao;
        }

        public void DefinirAfinidade(string afinidade)
        {
            if (string.IsNullOrWhiteSpace(afinidade))
            {
                throw new ArgumentException("A afinidade não pode ser vazia.", nameof(afinidade));
            }

            this.Afinidade = afinidade;
        }

        public void DefinirPrerequisito(int prerequisito)
        {
            if (prerequisito < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(prerequisito), "O pré-requisito não pode ser negativo.");
            }

            this.Prerequisito = prerequisito;
        }
    }
}
