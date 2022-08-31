string name;
string number;
string animal;
string part;

Console.WriteLine("Unfortunate accident generator 2000");
Console.WriteLine ("What's your name?");
name = Console.ReadLine();
Console.WriteLine ("Name your least liked animal.");
animal = Console.ReadLine();
Console.WriteLine ("Write a number.");
number = Console.ReadLine();
Console.WriteLine ("Write a part of you body.");
part = Console.ReadLine();

Console.WriteLine ($"Earlier this morning {name} unfortunatly got bitten by a {animal} and lost his {part}."); 
Console.WriteLine ($"He has been diagnosed with the horrific {animal} disease and is now slowly transforming into a {animal}."); 
Console.WriteLine ($"He unfortunatly only has {number} minutes left until the transformation is complete and he will be served at the ");
Console.WriteLine ($"Kentucky Fried {animal}s.");
Console.ReadLine();