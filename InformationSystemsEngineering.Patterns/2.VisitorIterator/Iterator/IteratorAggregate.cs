using System.Collections;

namespace InformationSystemsEngineering.Patterns.ObserverIterator.Iterator
{
    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}