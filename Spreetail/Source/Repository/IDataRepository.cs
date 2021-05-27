using System;
using System.Collections.Generic;
using System.Text;

namespace Spreetail.WorkSample.Source.Repository
{
    public interface IDataRepository
    {
        bool Add(string key, string value);

        void Clear();

        IEnumerable<KeyValuePair<string, string>> Items();

        IEnumerable<string> Keys();
        bool KeyExists(string key);

        IEnumerable<string> Members();

        IEnumerable<string> Members(string key);

        bool Remove(string key);

        bool Remove(string key, string value);

        bool ValueExists(string key, string value);
    }
}
