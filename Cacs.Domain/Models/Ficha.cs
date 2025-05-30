namespace Cacs.Domain.Models
{
    using Cacs.Domain.Models.Classe;
    using Cacs.Models.Itens;

    public class Ficha
    {
        public int Id { get; set; }
        public int NEX { get; set; }

        public int Agilidade { get; set; }
        public int Forca { get; set; }
        public int Intelecto { get; set; }
        public int Presenca { get; set; }
        public int Vigor { get; set; }

        public int PV { get; set; }
        public int PE { get; set; }
        public int SAN { get; set; }

        public int Defesa { get; set; }
        public int Bloqueio { get; set; }
        public int Esquiva { get; set; }

        public int Nivel => (int)Math.Ceiling(this.NEX / 5.0);

        public string NomePersonagem { get; set; } = string.Empty;
        public string NomeJogador { get; set; } = string.Empty;

        public string Deslocamento { get; set; } = string.Empty;

        public List<Pericia> Pericias { get; set; } = [];
        public List<Habilidade> Habilidades { get; set; } = [];
        public List<Item> Itens { get; set; } = [];
        public List<Ritual> Rituais { get; set; } = [];

        public ClasseBase Classe { get; set; }

        public Ficha(
            string nomePersonagem,
            int nex,
            int agilidade,
            int forca,
            int intelecto,
            int presenca,
            int vigor,
            List<Pericia> pericias,
            ClasseBase classe
            )
        {
            this.NomePersonagem = nomePersonagem;
            this.NEX = nex;
            this.Agilidade = agilidade;
            this.Forca = forca;
            this.Intelecto = intelecto;
            this.Presenca = presenca;
            this.Vigor = vigor;
            this.Pericias = pericias;
            this.Classe = classe;
        }

        public int CalcularBonusPericia(string nomePericia)
        {
            var pericia = this.Pericias.FirstOrDefault(p => p.Nome == nomePericia)
                ?? throw new InvalidOperationException($"Pericia '{nomePericia}' nao encontrada.");

            return pericia.NivelTreinamento.ObterBonus()
                + pericia.OutrosBonus
                + this.Nivel;
        }
    }
}
