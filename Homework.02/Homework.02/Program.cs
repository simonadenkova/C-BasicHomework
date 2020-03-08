using System;

namespace Excercises

{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise 1

            /* Console.WriteLine("Enter the first number");
             string userInput = Console.ReadLine();
             Console.WriteLine("Enter the second number");
             string userInput2 = Console.ReadLine();
             int userInputValue;
             int userInputValue2;
             if (!int.TryParse(userInput, out userInputValue) || !int.TryParse(userInput2, out userInputValue2))
             {
                 Console.WriteLine("Please enter a valid number!");
             }
             else if ((userInputValue > userInputValue2) && (userInputValue % 2 == 0))
             {
                 Console.WriteLine($"The number {userInputValue} is bigger than {userInputValue2} and it's even.");
             }
             else if ((userInputValue > userInputValue2) && (userInputValue % 2 == 1))
             {
                 Console.Write($"The number {userInputValue} is bigger than {userInputValue2} and it's odd.");
             }
             else if ((userInputValue2 > userInputValue) && (userInputValue2 % 2 == 0))
             {
                 Console.WriteLine($"The number {userInputValue2} is bigger and than {userInputValue} it's even.");
             }
             else if ((userInputValue2 > userInputValue) && (userInputValue2 % 2 == 1))
             {
                 Console.WriteLine($"The number {userInputValue2} is bigger than {userInputValue} and it's odd.");
             }
             else
             {
                 Console.WriteLine("The numbers are the same.");
             }*/

            //Excercise 2
            /*int userInputValue;
            Console.WriteLine("Please enter a number from 1 to 3");
            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput,out userInputValue) || (userInputValue <1) || (userInputValue>3) )
            {
                Console.WriteLine($"Enter a valid number!");
            } else
            {
                switch(userInputValue)
                {
                    case 1:
                        Console.WriteLine("You got a new car!");
                        break;
                    case 2:
                        Console.WriteLine("You got a new plane!");
                        break;
                    case 3:
                        Console.WriteLine("You got a new bike!");
                        break;
                    default:
                        Console.WriteLine("You won nothing!");
                        break;
                }

            }*/

            //Excercise 3 real calculator
            /* double num1;
             double num2;
             string operand;
             double result;

             Console.WriteLine("Enter the first number");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the second number");
             num2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter an operand");
             operand = Console.ReadLine();

             switch (operand)

             {
                 case "+":

                     result = num1 + num2;
                     break;


                 case "-":

                     result = num1 - num2;
                     break;


                 case "*":

                     result = num1 * num2;
                     break;


                 case "/":

                     result = num1 / num2;
                     break;


                 default:

                  result = 0;
                     break;

             }
             Console.WriteLine($"The answer is {result}");*/

            //Excercise 4 AverageNumber
            /*double num1;
            double num2;
            double num3;
            double num4;
            double result;

            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth number");
            num4 = Convert.ToInt32(Console.ReadLine());
            result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"The average of {num1}, {num2}, {num3}, and {num4} is {result}");*/


            //Excercise 5 SwapNumbers

           /* int num1;
            int num2;
            int swap;

            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swapping the first number is {num1} and the second is {num2}");
            swap = num1;
            num1 = num2;
            num2 = swap;
            Console.WriteLine($"After swapping the first number is {num1} and the second is {num2}");*/




          Console.ReadLine();

        }

    }
}
