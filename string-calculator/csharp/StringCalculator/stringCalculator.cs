using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
	public class stringCalculator
	{
		public int Add(string number)
		{
			var sum = 0;

			if (!String.IsNullOrEmpty(number))
			{
				const string pattern = @"\/\/\[.*\]\\n";
				var re = new Regex(pattern);

				var delimeter = re.Matches(number);
				number = re.Replace(number, string.Empty);


				number = number.Replace('\n', ',');
				number.Split(',').ToList().ForEach(x =>
					sum += Convert.ToInt32(x));
			}

			return sum;
		}
	}
}
