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
            const string instructor = "Navid Zare";

            Course course = new Course(id, name, isOnline, tuition, instructor);

            course.Id.Should().Be(id);
            course.Name.Should().Be(name);
            course.IsOnline.Should().Be(isOnline);
            course.Tuition.Should().Be(tuition);
            course.Instructor.Should().Be(instructor);
        }

        [Fact]
        public void Constructor_ShouldThrowException_When_NameIsNotProvided()
        {
            var courseBuilder = new CourseTestBuilder();

            Action course = () => courseBuilder.WithName(string.Empty).Build();

            course.Should().ThrowExactly<CourseNameIsInvalidException>();
        }

        [Fact]
        public void Constructor_ShouldThrowException_When_TuitionIsNotProvided()
        {
            var courseBuilder = new CourseTestBuilder();

            Action course = () => courseBuilder.WithTuition(0).Build();

            course.Should().ThrowExactly<CourseTuitionIsInvalidException>();
        }
    }
}
