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
    private Node _head;
    public int Length;

    public LinkedList()
    {
        Length = ComputeLength();
    }

    public void Add(Object value)
    {
        Node forAdding = new Node();
        forAdding.Value = value;
        Node current = _head;
        current.Next = forAdding;
    }

    public int ComputeLength()
    {
        return RecurseLength(_head);
    }

    private int RecurseLength(Node node)
    {
        if (node == null)
        {
            return 0;
        }
        else
        {
            return 1 + RecurseLength(node.Next);
        }
    }

    public void Insert(object val, int index)
    {
        throw new NotImplementedException();
    }

    public Node Get(int index)
    {
        throw new NotImplementedException();
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

        Console.WriteLine(myList1.ComputeLength());
        Console.WriteLine(myList1.Length);
    }
}