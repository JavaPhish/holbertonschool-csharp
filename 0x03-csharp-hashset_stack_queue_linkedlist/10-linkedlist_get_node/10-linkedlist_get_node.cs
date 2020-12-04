using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {        
        int index = 0;
        LinkedListNode<int> node = myLList.First;

        while (node.Next != null)
        {
            if (index == n) {
                return node.Value;
            }
            node = node.Next;
            index++;
        }

        return 0;
    }
}
