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

        [Theory]
        [InlineData(1, "", true, 600)]
        [InlineData(1, "TDD & BDD", true, 0)]
        public void Constructor_ShouldThrowException(int id, string name, bool isOnline, double tuition)
        {
            void Course() => new Course(id, name, isOnline, tuition);

            Assert.Throws<Exception>(Course);
        }
    }
}
