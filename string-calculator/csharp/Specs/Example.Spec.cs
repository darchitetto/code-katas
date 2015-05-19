using Given.Common;
using Given.NUnit;
using StringCalculator;

namespace Specs
{
	public class when_adding_zero_numbers : Scenario
	{
		private static stringCalculator s;

		given zero_numbers = () =>
		{
			s = new stringCalculator();
			_input1 = "";
		};

		private when adding_zero_numbers = () => _actual = s.Add(_input1);

		private static string _input1;
		private static int _actual;

		[then]
		public void it_should_return_the_summation_of_the_number()
		{
			_actual.ShouldEqual(0);
		}
	}

	public class when_adding_one_number : Scenario
	{
		private static stringCalculator s;

		given one_numbers = () =>
		{
			s = new stringCalculator();
			_input1 = "1";
		};

		private when adding_one_numbers = () => _actual = s.Add(_input1);

		private static string _input1;
		private static int _actual;

		[then]
		public void it_should_return_the_summation_of_the_number()
		{
			_actual.ShouldEqual(1);
		}
	}

	public class when_adding_two_numbers : Scenario
	{
		private static stringCalculator s;

		given two_numbers = () =>
		{
			s = new stringCalculator();
			_input1 = "1,2";
		};

		private when adding_two_numbers = () => _actual = s.Add(_input1);

		private static string _input1;
		private static int _actual;

		[then]
		public void it_should_return_the_summation_of_the_numbers()
		{
			_actual.ShouldEqual(3);
		}
	}

	public class when_adding_many_numbers : Scenario
	{
		private static stringCalculator s;

		given two_numbers = () =>
		{
			s = new stringCalculator();
			_input1 = "1,2,3,4,5";
		};

		private when adding_many_numbers = () => _actual = s.Add(_input1);

		private static string _input1;
		private static int _actual;

		[then]
		public void it_should_return_the_summation_of_the_numbers()
		{
			_actual.ShouldEqual(15);
		}
	}

	public class when_adding_two_numbers_seperated_by_newline : Scenario
	{
		private static stringCalculator s;

		given two_numbers = () =>
		{
			s = new stringCalculator();
			_input1 = "1\n2";
		};

		private when adding_two_numbers = () => _actual = s.Add(_input1);

		private static string _input1;
		private static int _actual;

		[then]
		public void it_should_return_the_summation_of_the_numbers()
		{
			_actual.ShouldEqual(3);
		}
	}

	public class when_adding_two_numbers_seperated_by_delimeter : Scenario
	{
		private static stringCalculator s;

		given two_numbers = () =>
		{
			s = new stringCalculator();
			_input1 = "//[;]\n1,2";
		};

		private when adding_two_numbers = () => _actual = s.Add(_input1);

		private static string _input1;
		private static int _actual;

		[then]
		public void it_should_return_the_summation_of_the_numbers()
		{
			_actual.ShouldEqual(3);
		}
	}
}
