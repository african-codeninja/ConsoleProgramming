// See https://aka.ms/new-console-template for more information

//Variables Declarations and Types
string fullname = string.Empty;
int age = 0;
double salary = 0;
char gender = char.MinValue;
bool working;

//Prompt User for Input for Username and capture it
Console.WriteLine("Please Enter Your Name: ");
fullname = Console.ReadLine();

//Prompt User for Input for Age and capture it
Console.WriteLine("Please Enter Your Age: ");
age = Convert.ToInt32(Console.ReadLine());

//Prompt User for Input for Salary and capture it
Console.WriteLine("Please Enter Your Salary: ");
salary = Convert.ToDouble(Console.ReadLine());

//Prompt User for Input for Gender and capture it
Console.WriteLine("Please Enter Your Gender (M of F): ");
gender = Convert.ToChar(Console.ReadLine());

//Prompt User for Input for Gender and capture it
Console.WriteLine("Are you working at this time? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

//Print the information back to the user
Console.WriteLine("Your name is: " + fullname);//concaternation
Console.WriteLine("Your Age is: {0}", age);
Console.WriteLine($"Your salary is: {salary}");//interpolation
Console.WriteLine("Your Gender is: " + gender);
Console.WriteLine("Your work status is: " + working);
