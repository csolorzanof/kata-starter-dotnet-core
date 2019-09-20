using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_user_input_is_two_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,2"); };

        It should_return_the_sum_of_both = () => { _result.Should().Be(3); };
        static Calculator _systemUnderTest;
        static int _result;
    }
}