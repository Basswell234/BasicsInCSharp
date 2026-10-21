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

static int AddNumbers(int a, int b)
{
    return a + b;
}

Console.WriteLine("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");  
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = AddNumbers(num1, num2);
Console.WriteLine("The sum is: " + sum);