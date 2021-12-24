namespace Academy.Domain
{
    public class Section
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }

        public Section(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}