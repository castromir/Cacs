namespace Cacs.Domain.Models
{
    public class Ficha
    {
        public int Id { get; set; }

        public string NomePersonagem { get; set; } = string.Empty;

        public int NEX { get; set; }

        public int Agilidade { get; set; }

        public int Forca { get; set; }

        public int Intelecto { get; set; }

        public int Presenca { get; set; }

        public int Vigor { get; set; }

        public List<Pericia> Pericias { get; set; } = [];

        public string Classe { get; set; } = string.Empty;

        public int PV { get; set; }

        public int PE { get; set; }

        public int SAN { get; set; }

        public Ficha(string nomePersonagem, int nex, int agilidade, int forca, int intelecto, int presenca, int vigor)
        {
            this.NomePersonagem = nomePersonagem;
            this.NEX = nex;
            this.Agilidade = agilidade;
            this.Forca = forca;
            this.Intelecto = intelecto;
            this.Presenca = presenca;
            this.Vigor = vigor;
        }

        public int CalcularBonusPericia(string nomePericia)
        {
            var pericia = this.Pericias.FirstOrDefault(p => p.Nome == nomePericia)
                ?? throw new InvalidOperationException($"Pericia '{nomePericia}' nao encontrada.");

            return pericia.NivelTreinamento.ObterBonus()
                + pericia.OutrosBonus
                + this.CalcularBonusNivel();
        }

        private int CalcularBonusNivel()
        {
            return (int)Math.Ceiling(this.NEX / 10.0);
        }
    }
}
