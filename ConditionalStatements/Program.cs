// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter Number of Apples: ");
int apples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number of Oranges: ");
int oranges = Convert.ToInt32(Console.ReadLine());


//If Statements ( ==, <, >, >=, <=, != )
if(oranges == apples)
{
    Console.WriteLine("You have the same number of Apples and Oranges");
}
else if (oranges > apples)
{
    Console.WriteLine("You have more Oranges");
}
else if (oranges < apples)
{
    Console.WriteLine("You have more Apples");
}


Console.WriteLine("Enter you final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
//Switch Statements
switch(grade)
{
    case int n when n <= 50:
        Console.WriteLine("You failed");
        break;
    case int n when n >=51 && n <= 60:
        Console.WriteLine("You got a E grade");
        break;
    case int n when n >= 61 && n <= 70:
        Console.WriteLine("You got a D grade");
        break;
    case int n when n >= 71 && n <= 80:
        Console.WriteLine("You got a C grade");
        break;
    case int n when n >= 81 && n <= 90:
        Console.WriteLine("You got a B grade");
        break;
    case int n when n >= 91 && n <= 100:
        Console.WriteLine("You got an A grade");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}


//Ternary Operators
//? represents if true then
//: represents if false then
var message = apples > oranges ? "You have more apples " : "You have more Orages";
Console.WriteLine(message);
