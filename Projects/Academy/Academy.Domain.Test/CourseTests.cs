using System;
using Academy.Domain;
using Xunit;

namespace Academy.Domain.Test
{
    public class CourseTests
    {
        [Fact]
        public void Constructor_ShouldConstructCourseProperly() // Happy path
        {
            const int id = 1;
            const string name = "TDD & BDD";
            const bool isOnline = true;
            const double tuition = 600;

            Course course = new Course(id, name, isOnline, tuition);

            Assert.Equal(id, course.Id);
            Assert.Equal(name, course.Name);
            Assert.Equal(isOnline, course.IsOnline);
            Assert.Equal(tuition, course.Tuition);
        }
        
        [Fact]
        public void Constructor_ShouldThrowException_When_NameIsNotProvided() // Happy path
        {
            const int id = 1;
            const string name = "";
            const bool isOnline = true;
            const double tuition = 600;

            void Course() => new Course(id, name, isOnline, tuition);

            Assert.Throws<Exception>(Course);
        } 
        
        [Fact]
        public void Constructor_ShouldThrowException_When_TuitionIsNotProvided() // Happy path
        {
            const int id = 1;
            const string name = "TDD & BDD";
            const bool isOnline = true;
            const double tuition = 0;

            void Course() => new Course(id, name, isOnline, tuition);

            Assert.Throws<Exception>(Course);
        }
    }
}
