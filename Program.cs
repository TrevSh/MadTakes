string name;
string food;
string favoriteStore;
string favoriteBook;
string favoriteBand;
string verbThrow;
string verbGrab;
string favoriteResturant;
string favoriteRPG;


Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Whats your name?");
Console.ForegroundColor = ConsoleColor.Green;
name = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Whats your favorite food?");
Console.ForegroundColor = ConsoleColor.Green;
food = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Whats a good word for 'throw'?");
Console.ForegroundColor = ConsoleColor.Green;
verbThrow = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Where do you buy your clothes?");
Console.ForegroundColor = ConsoleColor.Green;
favoriteStore = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Whats your favorite book?");
Console.ForegroundColor = ConsoleColor.Green;
favoriteBook = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Whats your favorite band?");
Console.ForegroundColor = ConsoleColor.Green;
favoriteBand = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Whats a good word for take?");
Console.ForegroundColor = ConsoleColor.Green;
verbGrab = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Whats your favorite place to eat");
Console.ForegroundColor = ConsoleColor.Green;
favoriteResturant = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("What game has the coolest character?");
Console.ForegroundColor = ConsoleColor.Green;
favoriteRPG = Console.ReadLine()!;


Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("There once was a man named"
    + name
    + "."
    + name 
    + " Really had thing against "
    + food
    + ". I mean, seriously,"
    + name
    + " used to " 
    + verbGrab 
    + " an arm's full of"
    + food
    + " from"
    + favoriteStore
    + " And spend all day just "
    + verbThrow
    + " them at"
    + favoriteBook
    + " fans while listening to a "
    + favoriteBand
    + " Soundtrack! "
    + " Oh yeah, "
    + name
    + " Really hated "
    + favoriteBook
    + " too but we wont get into that! "
    + name
    + " Once got fired from "
    + favoriteResturant
    + " For jumping on tables and while acting like the main character of "
    + favoriteRPG
    + ".");

