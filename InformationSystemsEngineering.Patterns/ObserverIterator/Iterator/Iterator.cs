using System;
using System.Collections;

namespace InformationSystemsEngineering.Patterns.ObserverIterator.Iterator
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        
        public abstract int Key();
        
        public abstract object? Current();
        
        public abstract bool MoveNext();
        
        public abstract void Reset();
    }

    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}