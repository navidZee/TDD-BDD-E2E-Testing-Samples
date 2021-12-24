using System;
using Academy.Domain;
using FluentAssertions;
using Xunit;

namespace Academy.Domain.Test
{
    public class SectionTests
    {
        [Fact]
        public void Constructor_ShouldConstructSectionProperly() // Happy path
        {
            //Arrang
            const int id = 1;
            const string name = "TDD & BDD";

            //Act
            Section section = new Section(id, name);

            //Verify
            section.Id.Should().Be(id);
            section.Name.Should().Be(name);
        }
    }
}
