using System;

/* BRONZE */

int num;
int age = 29;

string stringVar;
string myName = "Sean";

bool isAlive;
bool isMale = true;

float floatNum;
float anotherNum = 1.02f;

double latitude;
double oneThird = 3.33333333d;

decimal exactNum;
decimal moneyAmount = 30.04m;

// Unsigned long
ulong positiveNumber;
ulong maxValue = 18446744073709551615;


/* SILVER */ 

string myFirstName = "Sean";
string myLastName = "Dwyer";
string myFullName = myFirstName + ' ' + myLastName;

string words = "This is a string";
int someNum = 100;
string wordsPlusNumber = words + someNum;
Console.WriteLine(wordsPlusNumber);

/* GOLD */

string yearAsString = "2021";
int yearAsNum = int.Parse(yearAsString);
int anotherYearAsNum = Convert.ToInt32(yearAsString);
Console.WriteLine(yearAsNum);
Console.WriteLine(anotherYearAsNum);