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
            //Arreng
            const int id = 1;
            const string name = "TDD & BDD";
            const bool isOnline = true;
            const double tuition = 600;
            const string instructor = "Navid Zare";

            //Act
            Course course = new Course(id, name, isOnline, tuition, instructor);

            //Verify
            course.Id.Should().Be(id);
            course.Name.Should().Be(name);
            course.IsOnline.Should().Be(isOnline);
            course.Tuition.Should().Be(tuition);
            course.Instructor.Should().Be(instructor);
            course.Sections.Should().BeEmpty();
        }

        [Fact]
        public void Constructor_ShouldThrowException_When_NameIsNotProvided()
        { 
            //Arrang
            var courseBuilder = new CourseTestBuilder();

            //Act
            Action course = () => courseBuilder.WithName(string.Empty).Build();

            //Verify
            course.Should().ThrowExactly<CourseNameIsInvalidException>();
        }

        [Fact]
        public void Constructor_ShouldThrowException_When_TuitionIsNotProvided()
        {
            //Arrang
            var courseBuilder = new CourseTestBuilder();

            //Act
            Action course = () => courseBuilder.WithTuition(0).Build();

            //Verify
            course.Should().ThrowExactly<CourseTuitionIsInvalidException>();
        }

        [Fact]
        public void AddSection_ShouldAddNewSectionToSections_WhenIdAndNamePasses()
        {
            //Arrang
            var courseBuilder = new CourseTestBuilder();
            var course = courseBuilder.Build();
            var sectionToAdd = SectionFactory.Create();

            //Act
            course.AddSection(sectionToAdd);

            //Verify
            course.Sections.Should().ContainEquivalentOf(sectionToAdd);
        }
    }
}
