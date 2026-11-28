using Cacs.Domain.Models.SeedWork;

namespace Cacs.Domain.Inventario
{
    public sealed class ItemInventario : Entidade
    {
        public CaracteristicaComumItem CaracteristicaComum { get; private set; }

        public int Pontos => CaracteristicaComum.Pontos;

        public int EspacoOcupado => CaracteristicaComum.Espaco;

        public static ItemInventario Criar(
            CaracteristicaComumItem caracteristicaComum)
            => new(caracteristicaComum);

        public static ItemInventario Restaurar(
            Guid id,
            CaracteristicaComumItem caracteristicaComum)
            => new(id, caracteristicaComum);

        private ItemInventario(
            CaracteristicaComumItem caracteristicaComum)
        {
            ArgumentNullException.ThrowIfNull(caracteristicaComum);

            CaracteristicaComum = caracteristicaComum;
        }

        private ItemInventario(
            Guid id,
            CaracteristicaComumItem caracteristicaComum)
            : base(id)
        {
            ArgumentNullException.ThrowIfNull(caracteristicaComum);

            CaracteristicaComum = caracteristicaComum;
        }

        internal void Substituir(CaracteristicaComumItem caracteristicaComum)
        {
            ArgumentNullException.ThrowIfNull(caracteristicaComum);

            CaracteristicaComum = caracteristicaComum;
        }
    }
}
