namespace Cacs.Domain.Models.Itens
{
    using Cacs.Domain.Models.Enums;

    public class Equipamento : Item
    {
        public EquipamentoTag EquipamentoTag { get; private set; }
        public Equipamento(
            string nome,
            string descricao,
            int espaco,
            int categoria,
            Proficiencia? proficiencia,
            EquipamentoTag equipamentoTag)
            : base(nome, descricao, espaco, categoria, proficiencia)
        {
            this.EquipamentoTag = equipamentoTag;
        }
    }
}
