using System;

string firstName = "Sean";
Console.WriteLine(firstName);

Console.WriteLine("What is your favorite color?");
string colorInput = Console.ReadLine();
Console.WriteLine("You said your favorite color is " + colorInput);

Console.WriteLine("What is your first name?");
firstName = Console.ReadLine();
Console.WriteLine($"You said your first name is {firstName}");