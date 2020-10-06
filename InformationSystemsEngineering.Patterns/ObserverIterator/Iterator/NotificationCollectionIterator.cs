namespace InformationSystemsEngineering.Patterns.ObserverIterator.Iterator
{
    class NotificationCollectionIterator<T> : Iterator
    {
        private NotificationCollection<T> _collection;

        private int _position = -1;

        private bool _reverse = false;

        public NotificationCollectionIterator(NotificationCollection<T> collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = collection.Get().Count;
            }
        }

        public override object Current()
        {
            return _collection.Get()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.Get().Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.Get().Count - 1 : 0;
        }
    }
}