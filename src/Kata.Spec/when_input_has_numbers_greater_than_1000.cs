using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_input_has_numbers_greater_than_1000
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,2,1002,3"); };

        It should_return_the_sum_of_numbers_less_than_1001 = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }
}