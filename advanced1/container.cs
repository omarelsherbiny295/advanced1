

namespace advanced1
{
    internal class container<T> 
    {
        private T item;

        public void Add(T value)
        {
            item = value;
        }

        public T Get()
        {
            return item;
        }

    }
}
