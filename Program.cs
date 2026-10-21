// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
String? name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!");
 
// Methods 
static void GreetUser(string userName)
{
    Console.WriteLine("Welcome, " + userName + "!");
}

String? username = Console.ReadLine();
GreetUser(username);    