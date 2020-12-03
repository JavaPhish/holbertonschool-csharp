using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> array = new List<bool>();

        foreach (var item in myList)
        {
            if (item % 2 == 0)
                array.Add(true);
            else
                array.Add(false);         
        }

        return array;
    }
}
