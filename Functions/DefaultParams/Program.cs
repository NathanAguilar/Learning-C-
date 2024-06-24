using System;

// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string greeting ="", string name="Luke")
{
    Console.WriteLine($"{greeting} {name}");
}

// TODO: Test the default parameters
PrintWithPrefix(name: "Candy");
