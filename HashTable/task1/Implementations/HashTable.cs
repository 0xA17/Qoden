using System;
using System.Collections.Generic;
using HashTable.task1.Interfaces;


namespace HashTable.task1.Implementations;

class HashTable<T> : IHashTable<T>
{
    private readonly Int32 size;
    private readonly IHashFunction hashFunction;
    private readonly List<ILinkedList<T>> values;

    public HashTable(Int32 size, IHashFunction hashFunction)
    {
        this.size = size;
        this.hashFunction = hashFunction;
        values = new List<ILinkedList<T>>(size);
        for (Int32 i = 0; i < size; i++)
        {
            values.Add(new SinglyLinkedList<T>());
        }
    }

    public void Insert(T value)
    {
        Int32 index = hashFunction.GetHash(value.GetHashCode(), size);
        values[index].Insert(value);
    }

    public void PrintHashTable()
    {
        for (Int32 i = 0; i < size; i++)
        {
            Console.Write($"{i}: ");
            values[i].PrintList();
            Console.WriteLine();
        }
    }
}