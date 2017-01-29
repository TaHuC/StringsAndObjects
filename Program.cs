using System;

namespace StringsAndObjects
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			object integration = a + " " + b;

			Console.WriteLine($"{integration}");
		}
	}
}
