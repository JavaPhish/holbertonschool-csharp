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
    /// Prints the queue
    /// </summary>  
    public void Print()
    {
         if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Node p_node = head;

            while (p_node != null)
            {
                Console.WriteLine(p_node.value);
                p_node = p_node.next;
            }
        }

    }

    /// <summary>
    /// Concatenates all values (of string or char) together
    /// </summary>
    public String Concatenate()
    {
        Node p_node = head;
    
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) == typeof(string))
        {
            String s_full = "";
            while (p_node != null) {
                if (p_node.next != null)
                    s_full += (p_node.value + " ");
                else
                    s_full += (p_node.value);

                p_node = p_node.next;
            }
            return s_full;
        }

        if (typeof(T) == typeof(char))
        {
            
            String c_full = "";
            
            while (p_node != null) {
                c_full = c_full + p_node.value;
                p_node = p_node.next;
            }

            return c_full;
        }
        Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
        return null;
    }

    /// <summary>
    /// Node
    /// </summary>
    public class Node
    {
        /// Value of node
        public T value = default(T);
        /// Next node in queue
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
