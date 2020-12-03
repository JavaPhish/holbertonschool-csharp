﻿using System;
using System.Collections.Generic;


class List
{
    public static int MaxInteger(List<int> myList)
    {

        if (myList.Count < 1)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int max = myList[0];

        foreach (var item in myList)
            if (item > max)
                max = item;

        return max;
    }
}
