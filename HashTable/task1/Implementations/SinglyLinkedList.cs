using System;
using HashTable.task1.Interfaces;


namespace HashTable.task1.Implementations;

class SinglyLinkedList<T> : ILinkedList<T>
{
    class ListNode
    {
        public T Value;
        public ListNode Next;

        public ListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private ListNode head;

    public void Insert(T value)
    {
        ListNode newNode = new ListNode(value);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            ListNode currentNode = head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = newNode;
        }
    }

    public void PrintList()
    {
        ListNode currentNode = head;
        while (currentNode != null)
        {
            Console.Write($"{currentNode.Value} ");
            currentNode = currentNode.Next;
        }
    }
}