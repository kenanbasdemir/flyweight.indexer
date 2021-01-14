using Flyweight.Indexer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Indexer.Implementation
{
    public class Keyboard : IndexerBase<Key>
    {
        public string KeyboardName { get; set; }
    }
}
