
//Plan?
//Console Application?
//Ask user for name?
//Ask user for age?
//Bob or Sue, address them as professor?
//Otherwise address them as student?
//Under 21 recommend they wait x years to start class?


using System.ComponentModel.Design;

string? firstName = null;
int? age = null;
int? ageUntilTwentyOne = null;

Console.WriteLine("Welcome to the application: CapturingUserInfoThree");
Console.WriteLine("This application was created by: Justin Spencer");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();

Console.Write("What is your first name? ");
firstName = Console.ReadLine();
firstName = firstName?.ToLower();
Console.WriteLine();

Console.Write("What is your age? ");
age = Convert.ToInt32(Console.ReadLine());

switch (firstName)
{
    case "bob":
    case "sue":
        Console.WriteLine();
        Console.WriteLine("Hello, Professor.");
        break;
    default:
        Console.WriteLine();
        Console.WriteLine("Hello, learner.");
        break;
}
Console.WriteLine();

ageUntilTwentyOne = 21 - age;

if (age != null)
{
    if (age >= 21)
        Console.WriteLine("Welcome to the class!");
    else if (age < 21)
        Console.WriteLine($"Please wait {ageUntilTwentyOne} years to enroll.");
}
Console.WriteLine();
if (age >= 21)
{
    Console.WriteLine("Thank you for enrolling.");
}
else
{
    Console.WriteLine("Thank you for using the application.");
}
Console.ReadLine();