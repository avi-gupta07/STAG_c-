/*
 *Program to print number of days in a given month using switch case 
 */
Console.WriteLine("Use corresponding numbers to check number of days in that particular month." +
    "\n 1 --> January \n 2 --> February \n 3 -->March \n 4-->April \n 5 -->May \n 6 -->June \n" +
    " 7-->July \n 8-->August \n 9-->September \n 10-->October \n 11-->November \n 12-->December");

Console.WriteLine("Enter the month number: ");
int user_input =Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(user_input);

switch (user_input)
{
    case 1: 
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        {
            Console.WriteLine("You will 31 days");
        }
        break;
    case 4:
    case 6:
    case 9:
    case 11: { 
            Console.WriteLine("You will have 30 days."); 
        }
        break;
    case 2:
        {
            Console.WriteLine("You will have 28 days. If its a leap year then 29 days ");
        }
        break;
    default:{
            Console.WriteLine("Invalid input. Please enter from 1- 12 only.");
        }
        break;

  }