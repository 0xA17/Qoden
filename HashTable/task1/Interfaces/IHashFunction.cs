using System;

namespace HashTable.task1.Interfaces;

interface IHashFunction
{
    Int32 GetHash(Int32 value, Int32 tableSize);
}
