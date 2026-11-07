using Cacs.Domain.Models.SeedWork;

namespace Cacs.Domain.Inventario
{
    public class Inventario : IAggregateRoot
    {
        private const int MaxPontosCategoria = 16; // Todo, não será hardcoded, será definido por meio da ficha.

        private const int MaxEspaco = 20; // Todo, não será hardcoded, será definido por meio da ficha.

        private readonly List<Categoria> _categorias = [];

        private List<ItemInventario> _itens = [];

        public IReadOnlyCollection<ItemInventario> Itens =>
       _itens.AsReadOnly();

        public IReadOnlyCollection<Categoria> Categorias => _categorias;

        // public int Pontos => _categorias.Sum(c => c.Pontos); // TODO, ajustar pontos por meio de itens

        public int LimiteTotalCategoria => MaxPontosCategoria;

        public int LimiteTotalEspaco => MaxEspaco;

        // public int PontosDisponiveis => LimiteTotal - Pontos; // TODO, ajustar pontos por meio de itens

        private Inventario()
        {
        }
        
        public void AdicionarItem(
            EspecificacaoItem especificacao,
            int quantidade)
        {
            ArgumentNullException.ThrowIfNull(especificacao);

            var item = ItemInventario.Criar(
            quantidade,
            especificacao);

            _itens.Add(item);
        }

        private void RemoverItem()
        { }
    }
}
