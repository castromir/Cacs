namespace Cacs.Models.Itens
{
    public abstract class Item
    {
        protected int Id;
        protected int Espaco { get; set; }
        protected int Categoria { get; set; }
        protected string Nome { get; set; }
        protected string Descricao { get; set; }

    }
}
