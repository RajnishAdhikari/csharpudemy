using System;

namespace Welcome1
{
    internal class Welcome1
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("hey"); // after the statement executes it curser will be in the same line 
            // Console.Write("welcome to csharp ");                      curser will be in next line 
            Console.WriteLine("welcome\n to \n csharp \n course\n hahaha "); // \n helps to go to new line
            
            //string interpolation
            string person = "Paul";
            Console.WriteLine($"welcome to the Csharp course, { person}");
            

            //adding any two numbers
            int num1;
            int num2;
            int sum;
            Console.Write("Enter first integr: ");
            num1 = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter second integr: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine($"The sum is {sum}");
            */

            //SIMPLE IF STATEMENT
            Console.WriteLine("Enter first integer: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine($"{number1} == {number2}");
            }
            if (number1 != number2)
            {
                Console.WriteLine($"{number1} != {number2}");
            }

            if (number1 < number2)
            {
                Console.WriteLine($"{number1} < {number2}");
            }

            if (number1 > number2)
            {
                Console.WriteLine($"{number1} > {number2}");
            }

            if (number1 <= number2)
            {
                Console.WriteLine($"{number1} <= {number2}");
            }

            if (number1 >= number2)
            {
                Console.WriteLine($"{number1} >= {number2}");
            }


            Console.ReadLine();
            
        }
    }
}
