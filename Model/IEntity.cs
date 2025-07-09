namespace Model
{
    public interface IEntity
    {
        public int Id { get; }
        public string Name { get; }
        public DateTime? Date { get; }
    }
}
