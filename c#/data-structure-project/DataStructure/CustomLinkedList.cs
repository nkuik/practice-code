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

namespace DataStructure
{
    public class Node
    {
        public Node Next;
        public Object Value;
    }

    public class CustomLinkedList
    {
        private Node head;
        private Node current;

        public CustomLinkedList()
        { }

        public CustomLinkedList(Object value)
        {
            Node firstNode = new Node() { Value = value };
            AddFirst(firstNode);
        }

        private void AddFirst(Node headNode)
        {
            head = headNode;
            current = headNode;
        }

        public void Add(Object value)
        // Keep this null check just in case list isn't instantiated with value
        {
            Node forAdding = new Node() { Value = value };
            if (head == null)
            {
                AddFirst(forAdding);
            }
            else
            {
                forAdding.Next = head;
                head = forAdding;
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
            if (index > Length())
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Node thisNode = head;
                Node previousNode = null;
                for (int i = 0; i < index; i++)
                {
                    previousNode = thisNode;
                    thisNode = thisNode.Next;
                }
                previousNode.Next = null;
            }
        }

        public int Search(string search_val)
        {
            {
                Node thisNode = head;
                for (int i = 0; i < Length(); i++)
                {
                    if (thisNode.Value == search_val)
                    {
                        return i;
                    }
                    thisNode = thisNode.Next;
                }
                return -1;
            }
        }

        public Node Max(int index)
        {
            throw new NotImplementedException();
        }
    }
}