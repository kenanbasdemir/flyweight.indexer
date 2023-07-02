using System;
using Flyweight.Indexer.Implementation;

Keyboard keyboard = new Keyboard();
keyboard["k"].Value = "K";
keyboard["e"].Value = "E";
keyboard["n"].Value = "N";
keyboard["a"].Value = "A";

Console.WriteLine(keyboard["k"].Value);

keyboard.Remove("k");