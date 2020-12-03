using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        Dictionary<string, string> newDict = new Dictionary<string, string>();
 
        string sorted_keys[] = newDict.Keys.ToList();
        list.Sort();

        foreach (var item in list)
        {
            newDict.Add(list, myDict[list]);
        }

        return newDict;
    }
}
