
# Flyweight Indexer

The Flyweight Pattern is used to increase the production and performance of similar types of objects that are frequently used in memory.

An example of using the flyweight design pattern with an indexer.

## Usage/Examples

The following example is the indexer where a keyboard class manages the keys.

```csharp
public class Key
{
    public string Value { get; set; }
}

public class Keyboard : IndexerBase<Key>
{
    public string KeyboardName { get; set; }
}

static void Main()
{
    Keyboard keyboard = new Keyboard();
    keyboard["k"].Value = "K";
    keyboard["e"].Value = "E";
}

```

## Authors

- [@kenanbasdemir](https://www.github.com/kenanbasdemir)

