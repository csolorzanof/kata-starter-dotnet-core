using System;
using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_user_input_has_multiple_negative_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = Catch.Exception(()=> _systemUnderTest.Add("1,-2,3,-4")); };

        It should_throw_an_exception_listing_all = () => { _result.Message.Should().Be("negatives not allowed: -2, -4"); };
        static Calculator _systemUnderTest;
        static Exception _result;
    }
}