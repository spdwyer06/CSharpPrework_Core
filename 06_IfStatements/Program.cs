using System;

bool isRaining = true;
bool isGoingOutside = true;
bool hasUmbrella = true;

if(isRaining)
    Console.WriteLine("It's raining out!");

if(isRaining && isGoingOutside)
    Console.WriteLine("Better bring an umbrella.");

if(!isRaining || !isGoingOutside)
    Console.WriteLine("You don't need an umbrella.");

if(isRaining ^ isGoingOutside)
    Console.WriteLine("I will only go outside if it is not raining.");

if(isRaining && isGoingOutside && hasUmbrella)
    Console.WriteLine("Good thing you have an umbrella so you can go outside while it's raining.");

if(isGoingOutside)
    Console.WriteLine("Make sure to dress for the weather.");
else
    Console.WriteLine("Sounds like a sweats kind of day.");

Console.WriteLine("How are you feeling today on a scale of 1-5?");
// int userFeeling = int.Parse(Console.ReadLine());
int.TryParse(Console.ReadLine(), out int userFeeling);

if(userFeeling == 5)
    Console.WriteLine("That's great to hear!");
else if(userFeeling == 4)
    Console.WriteLine("Good stuff!");
else if(userFeeling == 3)
    Console.WriteLine("Hope things improve!");
else if(userFeeling == 2)
    Console.WriteLine("Oh, sorry to hear that.");
else if(userFeeling == 1)
    Console.WriteLine("Dang, I hope your day gets better!");
else    
    Console.WriteLine("Enter a valid rating (1-5).");