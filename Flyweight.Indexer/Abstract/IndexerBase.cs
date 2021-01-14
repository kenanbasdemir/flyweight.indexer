using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Indexer.Abstract
{
    public abstract class IndexerBase<T> where T : class, new()
    {
        private Dictionary<string, T> indexers = new Dictionary<string, T>();

        public T this[string indexer]
        {
            get
            {
                if (!indexers.ContainsKey(indexer))
                {
                    indexers.Add(indexer, new T());
                }
                return indexers[indexer];
            }
        }
    }
}
