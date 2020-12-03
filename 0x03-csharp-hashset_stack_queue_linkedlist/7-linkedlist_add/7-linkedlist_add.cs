using System;
using System.Collections.Generic;


class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> new_n = new LinkedListNode<int>(n);
        myLList.AddFirst(new_n);

        return new_n;
    }
}
