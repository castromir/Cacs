namespace Cacs.Domain.Models
{
    public class RitualFormaAvancada
    {
        public Guid Id { get; private set; }
        public string Nivel { get; private set; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        public int CustoPE { get; private set; }
    }
}
