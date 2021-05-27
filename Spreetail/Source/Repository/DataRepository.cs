using System;
using System.Collections.Generic;
using System.Linq;

namespace Spreetail.WorkSample.Source.Repository
{
    public class DataRepository : IDataRepository
    {
        private readonly IDictionary<string, ISet<string>> _dataStore;

        public DataRepository()
        {
            _dataStore = DataStore.Dictionary;
        }

        public bool Add(string key, string value)
        {
            _dataStore.TryGetValue(key, out var hashset);
            hashset ??= new HashSet<string>();
            var result = hashset.Add(value);
            _dataStore[key] = hashset;

            return result;
        }

        public void Clear()
        {
            _dataStore.Clear();
        }

        public IEnumerable<KeyValuePair<string, string>> Items()
        {
            return _dataStore.Keys.SelectMany(x => _dataStore[x].Select(m => new KeyValuePair<string, string>(x, m)));
        }

        public IEnumerable<string> Keys()
        {
            return _dataStore.Keys;
        }

        public bool KeyExists(string key)
        {
            return _dataStore.ContainsKey(key);
        }

        public IEnumerable<string> Members()
        {
            return _dataStore.Keys.SelectMany(x => _dataStore[x].Select(m => m));
        }

        public IEnumerable<string> Members(string key)
        {
            _dataStore.TryGetValue(key, out ISet<string> ret);
            return ret;
        }

        public bool Remove(string key)
        {
            return _dataStore.Remove(key);
        }
        
        public bool Remove(string key, string value)
        {
            _dataStore.TryGetValue(key, out ISet<string> mem);

            var result = mem.Remove(value);

            if (!mem.Any())
                _dataStore.Remove(key);

            return result;
        }

        public bool ValueExists(string key, string value)
        {
            return _dataStore.TryGetValue(key, out ISet<string> set) && set.Contains(value);
        }
    }

}
