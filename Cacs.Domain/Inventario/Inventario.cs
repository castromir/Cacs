using Cacs.Domain.Models.SeedWork;

namespace Cacs.Domain.Inventario
{
    public class Inventario : IAggregateRoot
    {
        private const int MaxPontosCategoria = 16;
        private const int MaxEspaco = 20;

        private readonly List<ItemInventario> _itens = [];

        public IReadOnlyCollection<ItemInventario> Itens =>
            _itens.AsReadOnly();

        public IReadOnlyCollection<PontosCategoria> Categorias =>
            _itens
                .GroupBy(i => i.CaracteristicaComum.CategoriaBase)
                .Select(g => new PontosCategoria(g.Key, g.Count()))
                .ToList()
                .AsReadOnly();

        public int LimiteTotalCategoria => MaxPontosCategoria;

        public int LimiteTotalEspaco => MaxEspaco;

        public int PontosUtilizados =>
            Categorias.Sum(c => c.Pontos);

        public int PontosDisponiveis =>
            LimiteTotalCategoria - PontosUtilizados;

        public int EspacosOcupados =>
            _itens.Sum(i => i.EspacoOcupado);

        public int EspacosDisponiveis =>
            LimiteTotalEspaco - EspacosOcupados;

        public bool EstaAcimaDoLimiteDePontos =>
            PontosUtilizados > LimiteTotalCategoria;

        public bool EstaAcimaDoLimiteDeEspaco =>
            EspacosOcupados > LimiteTotalEspaco;

        private Inventario()
        {
        }


        public void AdicionarItem(CaracteristicaComumItem caracteristicaComum)
        {
            ArgumentNullException.ThrowIfNull(caracteristicaComum);

            var item = ItemInventario.Criar(caracteristicaComum);

            _itens.Add(item);
        }

        public void RemoverItem(Guid itemInventarioId)
        {
            var item = _itens.FirstOrDefault(i => i.Id == itemInventarioId);

            if (item is null)
            {
                throw new InvalidOperationException(
                    "O item não pertence a este inventário.");
            }

            _itens.Remove(item);
        }       
    }
}
