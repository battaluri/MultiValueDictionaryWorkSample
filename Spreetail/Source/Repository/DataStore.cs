using System;
using System.Collections.Generic;
using System.Text;

namespace Spreetail.WorkSample.Source.Repository
{
    public class DataStore
    {
        private static DataStore instance = null;
        public static IDictionary<string, ISet<string>> Dictionary = new Dictionary<string, ISet<string>>();

        private DataStore()
        {
        }

        public static DataStore Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataStore();
                }
                return instance;
            }
        }
    }
}
