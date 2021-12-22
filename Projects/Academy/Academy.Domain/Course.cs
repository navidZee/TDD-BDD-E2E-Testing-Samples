namespace Academy.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOnline { get; set; }
        public double Tuition { get; set; }

        public Course(int id, string name, bool isOnline, double tuition)
        {
            Id = id;
            Name = name;
            IsOnline = isOnline;
            Tuition = tuition;
        }
    }
}