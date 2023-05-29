using System;
using HashTable.task1.Interfaces;

namespace HashTable.task1.Implementations;

class ModuloHashFunction : IHashFunction
{
    public Int32 GetHash(Int32 value, Int32 tableSize)
    {
        return value % tableSize;
    }
}