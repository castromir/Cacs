using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacsShared.Models
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
        public List<Pericia> Pericias { get; set; } = new();

        public string Classe { get; set; } = string.Empty;

        public int PV { get; set; }
        public int PE { get; set; }
        public int SAN { get; set; }

        public Ficha()
        { }
        public Ficha(string nomePersonagem, int nex, int agilidade, int forca, int intelecto, int presenca, int vigor)
        {
            NomePersonagem = nomePersonagem;
            NEX = nex;
            Agilidade = agilidade;
            Forca = forca;
            Intelecto = intelecto;
            Presenca = presenca;
            Vigor = vigor;
        }
    }
}
