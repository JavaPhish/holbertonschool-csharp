﻿using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");
        Console.WriteLine($"First item: {aQueue.Peek()}");
        Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");

        aQueue.Enqueue(newItem);

        if (aQueue.Contains(search))
        {
            while (aQueue.Contains(search))
                aQueue.Dequeue();
        }

        return aQueue;
    }
}
