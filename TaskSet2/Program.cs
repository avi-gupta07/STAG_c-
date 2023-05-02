using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSet2
{
    internal class Program
    {
        public static void Print_menu() {
            Console.WriteLine("******* Enter the question number [1-11] to test that section ****************\n  *******\t And 0 to exit \t*******");
            Console.WriteLine("1. Write a factorial program using recursion.");
            Console.WriteLine("2. Write a C# program and compute the sum of the digits of an integer.");
            Console.WriteLine("3. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.");
            Console.WriteLine("4. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.");
            Console.WriteLine("5.Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.");
            Console.WriteLine("6. Write a C# Sharp program to check if a given string starts with 'C#' or not.");
            Console.WriteLine("7. Write a C# Sharp program to check if two given non-negative integers have the same last digit.");
            Console.WriteLine("8. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk. ");
            Console.WriteLine("9. Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.");
            Console.WriteLine("10.Write a program in C# Sharp to display the first n terms of Fibonacci series.");
            Console.WriteLine("11. Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string.");
        }

        public static int Find_factorial(int fact_num)
        {
            if (fact_num == 0) return 1;
            else
            {
                return fact_num * Find_factorial(fact_num - 1);
            }            
        }


        public static void  Find_sum_of_digits() {
            Console.WriteLine("Enter the number to find sum of its digits:");
            int dig = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Entered number is {dig}");
            int result = 0;
            while (dig >0)
            {
                result += (dig % 10);              // it will find the last digit of an integer and add it to the result
                dig /= 10;                             // it will convert the 3 digit number into 2 and goes on        
            }
            Console.WriteLine($"Sum of its digits is {result}");
            
        }

        public static bool Is_WithIn(int test_num, int comp_num, int diff_range)
        {

            Console.WriteLine(test_num+ " "+comp_num +" "+diff_range);
            if (test_num >= (comp_num - diff_range) && (test_num <= (comp_num + diff_range)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Exchange_characters()
        {
            Console.WriteLine(" Enter the string to exchange its first and last characters :");
            string user_input = Console.ReadLine();
            string result;
            int len = user_input.Length;


            if (len == 1) { 
                result = user_input;
                Console.WriteLine($"New String : {result}");
            }
            else if (len == 2)
            {
                result = user_input[1] +""+ user_input[0];                
                Console.WriteLine($"New String: {result}");
            }
            else if (len >2)
            {              
                result = string.Concat(user_input[len - 1], user_input.Substring(1, (len - 2)), user_input[0]);
                Console.WriteLine($"New String : {result}");
            }
            else
            {
                Console.WriteLine("Please enter the valid string");
            }


        }

        public static bool Is_multiple()
        {
            Console.WriteLine("Enter the number to check if it's a multiple of 3 or 7:");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num%3 == 0) || (num%7 ==0)){
                return true;
            }
            return false;
        }

        public static void Is_starting_with()
        {
            Console.WriteLine("Enter the String to check: ");
            string user_input = Console.ReadLine() ;
            if (user_input.StartsWith("C#"))
            {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("false");
            }
        }
         
        public static void Same_last_digit()
        {
            Console.WriteLine("Enter the numbers to check (seprated by commas): ");
            string user_input = Console.ReadLine();
            string[] checker = user_input.Split(',');
            int num1 = Convert.ToInt32(checker[0]);
            int num2 = Convert.ToInt32(checker[1]);

            if ((num1%10) == (num2%10))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public static void Display_pattern()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                } 
                Console.WriteLine();
            }
        }

        public static int Nth_series_item( int num)
        {
           if (num == 0) return 0;
           else if(num == 1)
            {
                return 1;
            }
            else
            {
                return (10* Nth_series_item(num-1)) +1;
            }

        }

        public static int Fibonacci_Series( int num )
        {
            if (num == 0 || num==1) { 
                return num;
            }
            else
            {
                return (Fibonacci_Series(num-1)+ Fibonacci_Series(num-2));
            }
           
        }

        public static void Count_ADC( string str)
        {
            int alpha_count =0, digit_count=0, char_count =0;
            for(int i=0;i<str.Length;i++) {
                int code = (int)str[i];
                
                if ((code >= 65 && code <= 90) || (code >= 97 && code < +122))
                {
                    alpha_count++;
                }
                else if (code >=48 && code<= 57)
                {
                    digit_count++;
                }
                else
                {
                    char_count++;
                }               
            }
            Console.WriteLine($"Number of alphabets: {alpha_count} \nNumber of Digits: {digit_count} \nNumber of Special characters {char_count}");
        }
        static void Main(string[] args)
        {
            bool is_play = true;
            do
            {
                Print_menu();
                Console.WriteLine("\n\nEnter the question number :");
                int user_response = Convert.ToInt32(Console.ReadLine());

                switch (user_response)
                {
                    case 0:
                        {
                            Console.WriteLine("Thank you for the input. Bye ");
                            is_play = false;
                        }
                        break;
                    case 1:
                        {
                            Console.WriteLine("Enter the number to find factorial of: ");
                            int user_fac_num = Convert.ToInt32(Console.ReadLine());
                            int res = Find_factorial(user_fac_num);
                            Console.WriteLine($" Factorial of {user_fac_num} is {res}");
                        }
                        break;
                    case 2:
                        {
                            Find_sum_of_digits();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter the number to check if its within 10 of 100 or 200");
                            int user_in = Convert.ToInt32(Console.ReadLine());
                            bool final_result = Is_WithIn(user_in, 100, 10) || Is_WithIn(user_in, 200, 10);
                            Console.WriteLine($"Result: {final_result}");

                        }
                        break;
                    case 4:
                        {
                            Exchange_characters();
                        }
                        break;
                    case 5:
                        {
                            bool res = Is_multiple();
                            Console.WriteLine(res);
                        }
                        break;
                    case 6:
                        {
                            Is_starting_with();
                        }
                        break;
                    case 7:
                        {
                            Same_last_digit();
                        }
                        break;
                    case 8:
                        {
                            Display_pattern();
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("Input the number of terms: ");
                            int user_input = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("user input " + user_input);
                            int total = 0;

                            while (user_input > 0)
                            {
                                total = total + Nth_series_item(user_input);
                                user_input--;
                            }
                            Console.WriteLine($"The sum is {total}");
                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine("Input the number of terms to display: ");
                            int user_input1 = Convert.ToInt32(Console.ReadLine());
                            int res = Fibonacci_Series(user_input1);
                            int counter = 0;
                            string output = "";

                            while (counter < user_input1)
                            {
                                output += Convert.ToString(Fibonacci_Series(counter)) + " ";
                                counter++;
                            }
                            Console.WriteLine("Result " + output);
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Enter the string to find the number of alphabets, digits and special characters:");
                            string test_string = Console.ReadLine();
                            Count_ADC(test_string);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid input. please enter between [1-11] only.");
                        }
                        break;
                }

                Console.WriteLine("Do you want to test another question? [1= true , 0 = false]");
                int user_res= Convert.ToInt32(Console.ReadLine());
                if (user_res ==0)
                {
                    is_play = false;
                } 
                else if (user_res ==1)
                {
                    is_play=true;
                }
                else
                {
                    Console.WriteLine("Invalid input[security issues]. Closing the program .");
                }
            } while (is_play);

            Console.WriteLine("Thank you for testing our programs");
























                Console.ReadLine(); 
        }
    }
}
