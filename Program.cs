string name;
string food;
string favoriteStore;
string favoriteBook;
string favoriteBand;
string verbThrow;
string verbGrab;
string favoriteResturant;
string favoriteRPG;

Console.WriteLine("Whats your name?");
name = Console.ReadLine()!;

Console.WriteLine("Whats your favorite food?");
food = Console.ReadLine()!;

Console.WriteLine("Whats a good word for 'throw'?");
verbThrow = Console.ReadLine()!;

Console.WriteLine("Where do you buy your clothes?");
favoriteStore = Console.ReadLine()!;

Console.WriteLine("Whats your favorite book?");
favoriteBook = Console.ReadLine()!;

Console.WriteLine("Whats your favorite band?");
favoriteBand = Console.ReadLine()!;

Console.WriteLine("Whats a good word for take?");
verbGrab = Console.ReadLine()!;

Console.WriteLine("Whats your favorite place to eat");
favoriteResturant = Console.ReadLine()!;

Console.WriteLine("What game has the coolest character?");
favoriteRPG = Console.ReadLine()!;



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

