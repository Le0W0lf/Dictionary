using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionary<TKey, TValue> :   IDictionary<TKey, TValue>,
                                                ICollection<KeyValuePair<TKey, TValue>>,
                                                IEnumerable<KeyValuePair<TKey, TValue>>,
                                                IEnumerable,
                                                IDictionary,
                                                ICollection,
                                                IReadOnlyDictionary<TKey, TValue>,
                                                IReadOnlyCollection<KeyValuePair<TKey, TValue>>
    {
        private struct Entry
        {
            public int hashCode;
            public int next;
            public TKey key;
            public TValue value;
        }



        public TValue this[TKey key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object this[object key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICollection<TKey> Keys => throw new NotImplementedException();

        public ICollection<TValue> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        ICollection IDictionary.Keys => throw new NotImplementedException();

        IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => throw new NotImplementedException();

        ICollection IDictionary.Values => throw new NotImplementedException();

        IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => throw new NotImplementedException();

        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public void Add(object key, object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool Contains(object key)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
