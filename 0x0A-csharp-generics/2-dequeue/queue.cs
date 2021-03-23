using System;

/// <summary>
/// Base queue
/// </summary>
public class Queue<T>
{
    Node head = null;
    Node tail = null;
    int count = 0;

    /// <summary>
    /// Returns this queues type
    /// </summary>
    public Type CheckType() {
        return (typeof(T));
    }

    /// <summary>
    /// Node
    /// </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public Node(T n)
        {
            value = n;
        }
    }

    /// <summary>
    /// Dequeue
    /// </summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            count = 0;
            return default(T);
        }

        T v = head.value;
        Node old = head;
        head = head.next;
        count--;
        return v;
    }

    /// <summary>
    /// Returns value of first node
    /// </summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    /// <summary>
    /// Adds a new node
    /// </summary>
    public void Enqueue(T n)
    {
         Node new_node = new Node(n);

        if (head == null)
        {
            head = new_node;
            tail = new_node;
        }
        else
        {
            tail.next = new_node;
            tail = new_node;
        }
        count++;
    }

    /// <summary>
    /// Returns the node count
    /// </summary>
    public int Count()
    {
        return count;
    }  
}
