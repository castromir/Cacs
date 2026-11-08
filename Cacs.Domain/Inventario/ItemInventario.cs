using Cacs.Domain.Models.SeedWork;

namespace Cacs.Domain.Inventario
{
    public sealed class ItemInventario : Entidade
    {
        public CaracteristicaComumItem CaracteristicaComum { get; private set; }

        public int Pontos => CaracteristicaComum.CategoriaBase.Custo;

        public int EspacoOcupado => CaracteristicaComum.Espaco;

        private ItemInventario(CaracteristicaComumItem caracteristicaComum)
        {
            CaracteristicaComum = caracteristicaComum;
        }

        public static ItemInventario Criar(CaracteristicaComumItem caracteristicaComum)
        {
            ArgumentNullException.ThrowIfNull(caracteristicaComum);

            return new ItemInventario(caracteristicaComum);
        }
    }
}
