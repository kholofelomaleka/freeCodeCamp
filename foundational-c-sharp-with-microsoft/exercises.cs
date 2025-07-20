// DECLARING STRING AND CHARACTER VARIABLES
string firstName = "Bob";
Console.WriteLine(firstName);

// Declare implicitly typed local variables
var firstName = "10";
var lastName = "20";
var fullNames = firstName + lastName; // equals 1020

var firstName = 10;
var lastName = 20;
var fullNames = firstName + lastName; // equals 30

// Character escape sequences
Console.WriteLine("Hello\nWorld!"); // Add a new line
Console.WriteLine("Hello\tWorld!"); // Add a tab
Console.WriteLine("Hello "World"!"); // Will fail
Console.WriteLine("Hello \"World\"!"); // Quotes escaped, therefore will succeed
Console.WriteLine("c:\source\repos"); // Will fail
Console.WriteLine("c:\\source\\repos"); // Will succeed

// Unicode escape characters
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// Combine verbatim literals and string interpolation
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");


// Challenge

// Attempt
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.Write("View English output:\n\t" + $@"c:\Exercise\{projectName}\data.txt");
Console.Write($"\n\n{russianMessage}:\n\t" + $@"c:\Exercise\{projectName}\ru-RU\data.txt");

//Console.WriteLine("");
//Console.WriteLine("");

// Solution
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t{englishLocation}\n");
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t{russianLocation}\n");


// BASIC OPERATIONS ON NUMBERS

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// cast results of integer division
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

// Increment & Decrement
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

// Use the increment operator before and after the value
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

// Challenge
int fahrenheit = 94;
decimal degrees = ((decimal)fahrenheit - 32m) * (5m / 9m);
Console.WriteLine($"The temperature is {degrees} Celsius");


