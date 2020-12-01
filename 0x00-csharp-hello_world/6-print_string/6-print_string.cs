using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		string substr = str.Substring(0, 9);
		Console.WriteLine("{0}{0}{0}\n{1}", str, substr);
      }
}
