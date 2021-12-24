using System;

namespace Academy.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOnline { get; set; }
        public double Tuition { get; set; }
        public string Instructor { get; set; }

        public Course(int id, string name, bool isOnline, double tuition,string instructor)
        {
            GuardAgainstInvalidName(name);
            GuardAgainstInvalidTuition(tuition);

            Id = id;
            Name = name;
            IsOnline = isOnline;
            Tuition = tuition;
            Instructor = instructor;
        }

        private static void GuardAgainstInvalidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Name Is Null");            
        } 

        private static void GuardAgainstInvalidTuition(double tuition)
        {
            if (tuition <= 0)
                throw new Exception("Name Is 0");            
        }
    }
}