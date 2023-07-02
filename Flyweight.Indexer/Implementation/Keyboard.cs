using Flyweight.Indexer.Abstract;

namespace Flyweight.Indexer.Implementation;

public class Keyboard : IndexerBase<Key>
{
    public string KeyboardName { get; set; }
}