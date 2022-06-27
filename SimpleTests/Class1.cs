// 11:33 PM

namespace SimpleTests
{
	internal class Class1
	{
		private readonly object value;
		private object items;

		public string s { get; set; }

		//SA1501 - statement should not be on a single line
		//SA1508 - closing braces should not be preceded by a blank line
		//SA1002 - space before semicolon
		//SA1008 - opening parenthesis should not be followed by a space
		public object Method()
		{
			lock (this)
			{
				return this.value;
			}
		}

		//SA1111 closing parenthesis should be on line of last parameter

		public string JoinName(string first, string last)
		{
			string name = JoinStrings(first,
				last);
			return name;
		}

		private string JoinStrings(string first, string last)
		{
			return (first + " " + last);
		}
	}
}