﻿using System;
using System.Collections.Generic;


class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        Console.WriteLine($"Top item: {aStack.Peek()}");
        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

        if (aStack.Contains(search))
        {
            while (aStack.Peek() != search)
                aStack.Pop();
            aStack.Pop();
        }

        aStack.Push(newItem);

        return aStack;
    }
}
