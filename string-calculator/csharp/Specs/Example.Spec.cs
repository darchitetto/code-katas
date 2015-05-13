using Given.Common;
using Given.NUnit;

namespace Specs
{
	public class when_adding_two_numbers : Scenario
	{
		
		given two_numbers = () =>
		{
			_input1 = 1;
			_input2 = 2;

		};

		private when adding_two_numbers = () => _actual = _input1 + _input2;

		private static int _input1;
		private static int _input2;
		private static int _actual;

		[then]
		public void it_should_return_the_summation_of_the_two_numbers()
		{
			_actual.ShouldEqual(3);
		}
	}
}
