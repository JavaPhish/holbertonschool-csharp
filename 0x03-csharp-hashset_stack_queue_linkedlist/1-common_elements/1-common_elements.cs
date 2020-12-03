using System;
using System.Collections.Generic;


class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> hash1 = new HashSet<int>();
        HashSet<int> hash2 = new HashSet<int>();

        /* Create two hash tables and intersect them.
            this gives us only the values that dont
            exist in both */
        foreach (var item in list1)
            hash1.Add(item);
        foreach (var item in list2)
            hash2.Add(item);

        hash1.IntersectWith(hash2);

        /* Convert it to an int collection */
        List<int> myList = new List<int>();
        foreach (var item in hash1)
            myList.Add(item);

        return (myList);
    }
}
