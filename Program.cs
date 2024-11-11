
Console.WriteLine("Hello, World!");

Console.Write("What is your name? -> ");
var userName = Console.ReadLine();

Console.Write($"How old are you? -> ");

var userAge = Console.ReadLine();




User newUser = new User
{
    Name = userName,
    Age = userAge
};


Console.WriteLine($"Hello {newUser.Name} you are {newUser.Age}");



public class User
{
    public required string Name { get; set; }
    public required string Age { get; set; }
};

