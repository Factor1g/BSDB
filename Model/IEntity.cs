namespace Model
{
    public interface IEntity
    {
        public int Id { get; }
        public string Megnevezes { get; }
        public DateTime? Date { get; }
    }
}
