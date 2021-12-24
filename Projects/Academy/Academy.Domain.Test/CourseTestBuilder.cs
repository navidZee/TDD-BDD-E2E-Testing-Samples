using System;
using Academy.Domain;
using FluentAssertions;
using Xunit;

namespace Academy.Domain.Test
{
    public class CourseTestBuilder
    {
        const int _id = 1;
        string _name = "Tdd & Bdd";
        bool _isOnline = true;
        double _tuition = 600;
        string _instructor = "Navid";

        public CourseTestBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        public CourseTestBuilder WithTuition(double tuition)
        {
            _tuition = tuition;
            return this;
        }

        public Course Build() => new Course(_id, _name, _isOnline, _tuition, _instructor);

    }
}
