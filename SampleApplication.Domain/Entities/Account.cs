namespace SampleApplication.Domain.Entities
{
    public class Account : IEntity, IAggregateRoot
    {
        public int AccountId { get; private protected set; }
        public int Number { get; private protected set; }
        public string Name { get; private protected set; }
    }
}
