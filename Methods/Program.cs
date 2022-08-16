// See https://aka.ms/new-console-template for more information

//Prototype - Defines a function (type, name and parameters)
//Definition - Has the code. It contains the code block
//Function Call - Makes the function
//Console.WriteLine();
//Console.ReadLine();
//DRY - Don't Repeat Yourself
//YAGNI - You Aren't Going to Need It
//Void Funtions - Completes a task and Moves along
void PrintMyName()
{
    Console.WriteLine("Moses Mbutha Mwangi");
}
void Addition(int num1, int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
}


//Value Returning Functions - Completes a task, returns a result
int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    if(largest < num2)
    {
        largest = num2;
    }
    if(largest < num3)
    {
        largest = num3;
    }
    return largest;
}



Console.WriteLine("Enter Number of Apples: ");
int apples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number of Oranges: ");
int oranges = Convert.ToInt32(Console.ReadLine());




Console.WriteLine("Enter Number 1: ");
int number1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

PrintMyName();
Addition(apples, oranges);
int result = LargestNumber(number1, number2, number3);

Console.WriteLine($"From the sequence the largest number is: {result}");