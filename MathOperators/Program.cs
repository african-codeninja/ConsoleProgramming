// See https://aka.ms/new-console-template for more information


//Basic Assignment Operators
int num; //int num = 5;
num = 5;

//Arithmetic Operators
int num1 = 11;
int num2 = 12;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num2 - num1}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num2 / num1}");
Console.WriteLine($"Modulus: {num2 % num1}");

//num1  = num1 + 4;
num1 += 4;
Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");
//Compound Assignment Operator

num1 += 4;
Console.WriteLine($"num1 += 4: {num1}");
num1 -= 4;
Console.WriteLine($"num1 -= 4: {num1}");
num1 *= 4;
Console.WriteLine($"num1 *= 4: {num1}");
num1 /= 4;
Console.WriteLine($"num1 /= 4: {num1}");
num1 %= 4;
Console.WriteLine($"num1 %= 4: {num1}");
