using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> list = new LinkedList<int>();

        while (size > 0)
        {
            size--;
            LinkedListNode<int> new_n = new LinkedListNode<int>(size);
            list.AddFirst(new_n);
        }

        foreach (var item in list)
            Console.WriteLine(item);

        return list;
    }
}
