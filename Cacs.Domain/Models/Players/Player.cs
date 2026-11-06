using Cacs.Domain.Models.SeedWork;

namespace Cacs.Domain.Models.Players
{
    public class Player : Entidade, IAggregateRoot
    {
        private const int MaxPontos = 16;

        private readonly List<Categoria> _categorias = [];

        public IReadOnlyCollection<Categoria> Categorias => _categorias;

        public int Pontos => _categorias.Sum(c => c.Pontos);

        public int LimiteTotal => MaxPontos;

        public int PontosDisponiveis => LimiteTotal - Pontos;

        public string Nome { get; private set; } = string.Empty;

        private Player(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException(
                    "O nome do jogador não pode ser vazio.",
                    nameof(nome));
            }

            Nome = nome;
        }

        private Player(Guid id, string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException(
                    "O nome do jogador não pode ser vazio.",
                    nameof(nome));
            }

            Id = id;
            Nome = nome;
        }

        public static Player Criar(string nome)
        {
            var player = new Player(nome);

            player._categorias.Add(new Categoria(CategoriaNivel.I, 0));
            player._categorias.Add(new Categoria(CategoriaNivel.II, 0));
            player._categorias.Add(new Categoria(CategoriaNivel.III, 0));
            player._categorias.Add(new Categoria(CategoriaNivel.IV, 0));

            return player;
        }

        public static Player Restaurar(
            Guid id,
            string nome,
            IEnumerable<Categoria> categorias)
        {
            var player = new Player(id, nome);

            player._categorias.AddRange(categorias);

            return player;
        }

        public void MudarCategoria(
            CategoriaNivel nivel,
            int novaQuantidade)
        {
            var categoria = _categorias.FirstOrDefault(
                c => c.Nivel == nivel);

            if (categoria is null)
            {
                throw new InvalidOperationException(
                    "Categoria não encontrada.");
            }

            var pontosSemCategoria = Pontos - categoria.Pontos;
            var novosPontos = (int)categoria.Nivel * novaQuantidade;

            if (pontosSemCategoria + novosPontos > LimiteTotal)
            {
                throw new InvalidOperationException(
                    $"O jogador não pode ultrapassar {LimiteTotal} pontos.");
            }

            categoria.AlterarQuantidade(novaQuantidade);
        }
    }
}
