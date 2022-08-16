// See https://aka.ms/new-console-template for more information




Person person = new Person();
string middleName = string.Empty;

Console.WriteLine("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Current yearly pay: ");
double salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Middle Name: ");
middleName = Console.ReadLine();

if(string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Full Name is: " + person.getFullName());
}
else
{
    Console.WriteLine("Full Name is: " + person.getFullName(middleName));
}

person.setSalary(salary);

Console.WriteLine($"Full name is: {person.getFullName()}");
//Console.WriteLine($"First name is: {person.FirstName}");
//Console.WriteLine($"Lastname is: {person.LastName}");
Console.WriteLine($"Ageis: {person.Age}");
Console.WriteLine($"Salary is: {person.getSalary()}");
Console.WriteLine($"Your year of birth is: {person.getYearOfBirth()}");
