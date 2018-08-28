using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Collections
{
    public class CollectionManager<T> : IEnumerable<T>
    {
        private Dictionary<string, T> genDict = new Dictionary<string, T>();

        public void Add(string key, T value)
        {
            genDict.Add(key, value);
        }

        public T this[string key]
        {
            get { return genDict.First(g => g.Key == key).Value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)genDict).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)genDict).GetEnumerator();
        }
    }
}
