

namespace advanced1
{
    internal class safelist<T>

    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
                return default(T);

            return items[index];
        }

    }
}