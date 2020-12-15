using System.Collections;
using System.Collections.Generic;

namespace InformationSystemsEngineering.Patterns.ObserverIterator.Iterator
{
    class TransportCollection<T> : IteratorAggregate
    {
        List<T> _collection = new List<T>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<T> Get()
        {
            return _collection;
        }

        public void Add(T item)
        {
            _collection.Add(item);
        }
        
        public void Remove(T item)
        {
            _collection.Remove(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new TransportCollectionIterator<T>(this, _direction);
        }
    }
}