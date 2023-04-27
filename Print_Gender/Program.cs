/*
 * A program printing Male/female gender based upon given M/F 
 */
Console.WriteLine("Use M for Male and F- Female.Any other character will not be accepted ");

Console.WriteLine("Enter your gender info: ");
string user_input = Console.ReadLine().ToUpper();
if (user_input == "M")
{
    Console.WriteLine("You have entered M --> Male");
}
else if (user_input == "F")
{
    Console.WriteLine("You have entered F --> Female");
}
else if (user_input == "")  // why null is not working in this case.
{
    Console.WriteLine("You have not entered anything.Please choose M --> male and  F --> Female.");
}
else
{
    Console.WriteLine("Please enter only M or F");
}

