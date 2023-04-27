/*
 * Simple Calculator [ program doing basic arithmatic operations using switch case] 
 */

Console.WriteLine("********* Simple Calculator ********* ");

//Taking user input (First number , second number and operation)
Console.WriteLine("Enter the First number :");
double first_number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double second_number  = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter corresponding symbol to perform that function " +
    "\n ( + )--> Sum \n ( - ) --> Subtract \n ( * )--> Multiply \n ( / ) --> Division");
Console.WriteLine("Enter the operation symbol from above: ");
string? user_selection  = Console.ReadLine();

double result = 0.0;
switch (user_selection)
{
    case "+": result = first_number+second_number;
        break;
    case "-": result = first_number - second_number;
        break;
    case "*": result =first_number*second_number;
        break; 
    case "/":
        {   
            if (second_number != 0)
            {
                result = first_number / second_number;
            }
        }
        break;
    default: Console.WriteLine("Please enter the valid symbol [ +, - , * , / ] only");
        break;
}
if(!(second_number == 0 && user_selection == "/")) {
    Console.WriteLine($"Result : {first_number} {user_selection} {second_number} = " + result);   
}
else
{
    Console.WriteLine("Undefined. You cannot divide any number by 0");
}
