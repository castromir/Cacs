namespace Cacs.Domain.Models
{
    using Cacs.Domain.Models.Classe;
    using Cacs.Domain.Models.Enums;
    using Cacs.Models.Itens;

    public class Ficha
    {
        public int Id { get; private set; }
        public int NEX { get; private set; }

        public int PV { get; private set; }
        public int PE { get; private set; }
        public int SAN { get; private set; }

        public int Defesa { get; private set; }
        public int Bloqueio { get; private set; }
        public int Esquiva { get; private set; }

        public int Nivel => (int)Math.Ceiling(this.NEX / 5.0);

        public string NomePersonagem { get; private set; } = string.Empty;
        public string NomeJogador { get; private set; } = string.Empty;
        public string Deslocamento { get; private set; } = string.Empty;

        public List<Habilidade> Habilidades { get; private set; } = [];
        public List<Item> Itens { get; private set; } = [];
        public List<Ritual> Rituais { get; private set; } = [];

        public ClasseBase Classe { get; private set; }

        private readonly List<Pericia> pericias = [];
        private readonly List<Atributo> atributos = [];
        public IReadOnlyCollection<Pericia> Pericias => this.pericias.AsReadOnly();
        public IReadOnlyCollection<Atributo> Atributos => this.atributos.AsReadOnly();

        public Ficha(
            string nomePersonagem,
            int nex,
            ClasseBase classe
            )
        {
            this.NomePersonagem = nomePersonagem;
            this.NEX = nex;
            this.Classe = classe;

            foreach (NomePericia nome in Enum.GetValues(typeof(NomePericia)))
            {
                this.pericias.Add(new Pericia(nome));
            }
        }

        public Pericia ObterPericia(NomePericia nome)
        {
            return this.pericias.First(p => p.NomePericia == nome);
        }

        public void AtualizarOutrosBonusPericia(NomePericia nome, int bonus)
        {
            var pericia = this.ObterPericia(nome);
            pericia.DefinirOutrosBonus(bonus);
        }

        public void AtualizarTreinamentoPericia(NomePericia nome, Treinamento nivel)
        {
            var pericia = this.pericias.FirstOrDefault(p => p.NomePericia == nome)
                ?? throw new InvalidOperationException($"Perícia '{nome}' não encontrada.");
            pericia.DefinirNivel(nivel);
        }

        public int CalcularBonusPericia(NomePericia nomePericia)
        {
            var pericia = this.Pericias.FirstOrDefault(p => p.NomePericia == nomePericia)
                ?? throw new InvalidOperationException($"Pericia '{nomePericia}' nao encontrada.");

            return pericia.NivelTreinamento.ObterBonus()
                + pericia.OutrosBonus
                + this.Nivel;
        }
    }
}
