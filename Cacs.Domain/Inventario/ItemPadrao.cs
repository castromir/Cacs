using Cacs.Domain.Inventario.Enums;
using Cacs.Domain.Models.SeedWork;

namespace Cacs.Domain.Inventario
{
    public sealed class ItemPadrao : Entidade, IAggregateRoot
    {
        public CaracteristicaComumItem CaracteristicaComum { get; private set; }

        // Método (usar factory?) para criar um item padrão no Arsenal
        // Método para alterar um item no Arsenal


        // O construtor de Item deve ser algo rígido, contendo todos os atributos de CaracteristicaComumItem, menos Descricao. Todo, colocar isso em requisitos.
        private ItemPadrao(string nome)
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

    }
}
