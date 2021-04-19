using System;

bool isCool = false;
isCool = true;

/* BOOLEAN LOGICAL OPERATORS */

// Negation Operator
bool isTrue = !false;
bool isFalse = !isTrue;

// AND Operator
bool trueAndExample = true && true;
bool falseAndExample = true && false;

// OR Operator
bool trueOrExample = true || false;
bool falseExample = false || false;

// XOR Operator (Exclusive Or)
bool trueExclusiveOrExample = true ^ false;
bool falseExclusiveOrExample = true ^ true;


/* COMPARISON OPERARATORS */

bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqualTo = 10 >= 10;
Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}");

bool isLessThan = 5 < 5;
bool isLessThanOrEqualTo = 5 <= 5;
Console.WriteLine($"5< 5 is {isLessThan}, and 5 <= 5 is {isLessThanOrEqualTo}");

bool areEqual = 17 == 9;
bool areNotEqual = 17 != 9;
Console.WriteLine($"17 == 9 is {areEqual}, and 17 != 9 is {areNotEqual}");