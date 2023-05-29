using System;
using HashTable.task1.Implementations;
using HashTable.task1.Interfaces;

namespace HashTable.task1;

internal class Program
{
    static void Main()
    {
        Int32 N = Int32.Parse(Console.ReadLine());
        IHashFunction hashFunction = new ModuloHashFunction();
        IHashTable<Int32> hashTable = new HashTable<Int32>(N, hashFunction);

        String[] elements = Console.ReadLine().Split(' ');
        foreach (String element in elements)
        {
            Int32 newValue = Int32.Parse(element);
            hashTable.Insert(newValue);
        }

        hashTable.PrintHashTable();
    }
}