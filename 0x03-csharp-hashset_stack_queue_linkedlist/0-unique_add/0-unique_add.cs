using System;
using System.Collections.Generic;

class List
{
	public static int Sum(List<int> myList)
	{
		List<int> used_n = new List<int>();
		int sum = 0;

		foreach (var num in myList)
		{
			if (used_n.Contains(num))
				continue;

			sum += num;
			used_n.Add(num);
		}
		return sum;
	}
}

