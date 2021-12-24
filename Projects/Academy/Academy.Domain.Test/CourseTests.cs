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
            const string instructor = "Navid";

            Course course = new Course(id, name, isOnline, tuition, instructor);

            course.Id.Should().Be(id);
            course.Name.Should().Be(name);
            course.IsOnline.Should().Be(isOnline);
            course.Tuition.Should().Be(tuition);
            course.Instructor.Should().Be(instructor);
        }

        [Theory]
        [InlineData("", 600)]
        [InlineData("TDD & BDD", 0)]
        public void Constructor_ShouldThrowException(string name, double tuition)
        {
            var courseBuilder = new CourseTestBuilder();

            Action course = () => courseBuilder.WithName(name).WithTuition(tuition).Build();

            course.Should().Throw<Exception>();
        }
    }
}
