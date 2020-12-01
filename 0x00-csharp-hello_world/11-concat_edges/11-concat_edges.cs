using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		str = str.Remove(0, 49);
		str = str.Remove(15, 15);
		str += str.Substring(37, 3);
		str = str.Remove(27, 27);
		str = str.Remove(30, 104);
		Console.WriteLine(str);
    }
}
