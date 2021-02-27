using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Add, 2 - Subtract, 3 - Divide, 4 - Multiply");
            int calc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1st Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (calc)
            {
                case 1:
                    {
                        addition(num1, num2);
                        break;
                    }

                case 2:
                    {
                        subtraction(num1, num2);
                        break;
                    }

                case 3:
                    {
                        division(num1, num2);
                        break;
                    }

                case 4:
                    {
                        multiplication(num1, num2);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid");
                        break;
                    }                  
            }
            Console.ReadKey();
        }

        static void addition(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.WriteLine("Answer is: " + answer);
        }

        static void subtraction(int num1, int num2)
        {
            int answer = num1 - num2;
            Console.WriteLine("Answer is: " + answer);
        }

        static void division(int num1, int num2)
        {
            int answer = num1 / num2;
            Console.WriteLine("Answer is: " + answer);
        }

        static void multiplication(int num1, int num2)
        {
            int answer = num1 * num2;
            Console.WriteLine("Answer is: " + answer);
        }
    }
}
