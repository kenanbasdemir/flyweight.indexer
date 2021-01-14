using Flyweight.Indexer.Implementation;
using System;

namespace Flyweight.Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Keyboard keyboardKey = new Keyboard();
            keyboardKey["k"].KeyValue = "K";
            keyboardKey["e"].KeyValue = "E";

            Console.WriteLine(keyboardKey["k"].KeyValue);
        }
    }
}
