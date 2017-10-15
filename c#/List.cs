using System;
 
// A beginner's implementation of a linked List. It should contain the
// following methods:

// NewList() -> List L              # creates an empty list
// Length(List L) -> int n         # returns length of L
// Insert(List L, value x, int i)  # inserts x into L at index i (in-place)
// Get(List L, int i) -> value x  # returns value in L at index i
// Remove(List L, int i) ->       # remove the item at index i (in-place)

// Search(List L, value x) -> int i  # return the index of the first occurrence of x in L, or -1 if it is not found.
// Max(List L) -> value x              # return the largest value in 

public class Node
{
    public Node Next;
    public Object Value;
}

public class LinkedList
{
    private Node head;
    private Node current;

    public void Add(Object value)
    {
        Node forAdding = new Node();
        forAdding.Value = value;
        if (head == null)
        {
            head = forAdding;
            current = head;
        }
        else
        {
            current.Next = forAdding;
            current = forAdding;
        }
    }

    public int Length()
    {
        return RecursiveLength(head);
    }

    private int RecursiveLength(Node node)
    {
        if (node == null)
        {
            return 0;
        }
        else
        {
            return 1 + RecursiveLength(node.Next);
        }
    }

    public void Insert(object val, int index)
    {
        if (index > Length())
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            Node thisNode = head;
            for (int i = 0; i < index; i++)
            {
                thisNode = thisNode.Next;
            }
            Node next = thisNode.Next;
            thisNode.Next = new Node () { Value = val, Next = next };
        }
    }

    public Node Get(int index)
    {
        Node thisNode = head;
        for (int i = 0; i < index; i++)
            {
                thisNode = thisNode.Next;
            }
        return thisNode;
    }

    public void Remove(int index)
    {
        throw new NotImplementedException();
    }

    public Node Search(Node search_val)
    {
        throw new NotImplementedException();
    }

    public Node Max(int index)
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Add First:");
        LinkedList myList1 = new LinkedList();

        myList1.Add("Hello World");
        myList1.Add("Poo");
        myList1.Insert("This", 1);
        myList1.Add("Another");

        Node poo = myList1.Get(1);
        Console.WriteLine(poo.Value);
    }
}