using System;


string firstName = "Sean";
string lastName = "Dwyer";

// Concatenation
string concatenatedFullName = firstName + ' ' + lastName;
Console.WriteLine(concatenatedFullName);

// Interpolation
string interpolatedFullName = $"{firstName} {lastName}";
Console.WriteLine(interpolatedFullName);

// Composite Formatting
string compositeFullName = string.Format("{0} {1}", firstName, lastName);
Console.WriteLine(compositeFullName);