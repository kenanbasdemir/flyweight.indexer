using System;
using Flyweight.Indexer.Implementation;

Keyboard keyboard = new Keyboard();
keyboard["k"].Value = "K";
keyboard["e"].Value = "E";
keyboard["n"].Value = "N";
keyboard["a"].Value = "A";

string firstName = string.Concat(
    keyboard["k"].Value,
    keyboard["e"].Value,
    keyboard["n"].Value,
    keyboard["a"].Value,
    keyboard["n"].Value);

Console.WriteLine(firstName);