// See https://aka.ms/new-console-template for more information
/*/* ask the user for their personal info
if they are an adult
 - HAHA Took your bank info
Not an adult
 -Don't give out your personal info
Console.WriteLine("Hello, World!");*/
Console.WriteLine("Welcome to the INFO-COLLECTOR");
Console.WriteLine("Enter your Name: ");
string? name = Console.ReadLine();
Console.WriteLine($"Hello {name}!!!");
Console.WriteLine("What's your age? ");
int age = int.Parse(Console.ReadLine()) ;
Console.WriteLine($"{name} what is your homeTown?");
string? townName = Console.ReadLine();

if (age>=18)
{
    Console.WriteLine($"{name} HAHAHA.... I am going to take your account from {townName}");
}
else
{
    Console.WriteLine($"{name} don't share your info with others");
}