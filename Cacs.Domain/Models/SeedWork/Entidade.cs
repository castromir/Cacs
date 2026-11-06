namespace Cacs.Domain.Models.SeedWork
{
    public abstract class Entidade
    {
        public Guid Id { get; private set; }

        protected Entidade()
        {
            Id = Guid.NewGuid();
        }

        protected Entidade(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException(
                    "O identificador não pode ser vazio.",
                    nameof(id));
            }

            Id = id;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Entidade outra)
            {
                return false;
            }

            if (ReferenceEquals(this, outra))
            {
                return true;
            }

            return GetType() == outra.GetType()
                && Id == outra.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GetType(), Id);
        }

        public static bool operator ==(
            Entidade? esquerda,
            Entidade? direita)
        {
            return Equals(esquerda, direita);
        }

        public static bool operator !=(
            Entidade? esquerda,
            Entidade? direita)
        {
            return !Equals(esquerda, direita);
        }
    }
}
