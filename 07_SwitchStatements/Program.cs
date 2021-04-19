using System;

Console.WriteLine("How are you feeling today on a scale of 1-5?");
int.TryParse(Console.ReadLine(), out int userFeeling);

switch(userFeeling)
{
    case 5:
        Console.WriteLine("That's great to hear!");
        break;
    case 4:
        Console.WriteLine("Good stuff!");
        break;
    case 3:
        Console.WriteLine("Hope things improve!");
        break;
    case 2: 
        Console.WriteLine("Oh, sorry to hear that.");
        break;
    case 1:
        Console.WriteLine("Dang, I hope your day gets better!");
        break;
    default:
        Console.WriteLine("Enter a valid rating (1-5).");
        break;
}