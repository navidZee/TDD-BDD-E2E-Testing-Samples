using System;
using Academy.Domain;
using FluentAssertions;
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

            course.Id.Should().Be(id);
            course.Name.Should().Be(name);
            course.IsOnline.Should().Be(isOnline);
            course.Tuition.Should().Be(tuition);
        }

        [Theory]
        [InlineData(1, "", true, 600)]
        [InlineData(1, "TDD & BDD", true, 0)]
        public void Constructor_ShouldThrowException(int id, string name, bool isOnline, double tuition)
        {
            Action course = () => new Course(id, name, isOnline, tuition);

            course.Should().Throw<Exception>();
        }
    }
}
