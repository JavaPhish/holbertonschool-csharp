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
        
        return v;
    }

    /// <summary>
    /// Adds a new node
    /// </summary>
    public Node Enqueue(T n)
    {
        if (head == null)
        {
            head = new Node(n);
        }
        else
        {
            Node new_node = new Node(n);
            new_node.next = head;

            head = new_node;
        }

        count = 1;
        tail = head;
        while (tail.next != null)
        {
            tail = tail.next;
            count++;
        }

        return head;
    }

    /// <summary>
    /// Returns the node count
    /// </summary>
    public int Count()
    {
        int counter = 0;
        Node temp = head;
        while (temp != null)
        {
            counter++;
            temp = temp.next;
        }

        count = counter;

        return counter;
    }
}
