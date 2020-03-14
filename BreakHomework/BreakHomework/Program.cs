using System;

namespace BreakExercises

{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise 1-flip the boolean

           /* Console.WriteLine("Enter true or false.");
            string userInput = Console.ReadLine();
            if(userInput=="true")
            {
                Console.WriteLine(false);
            } else if(userInput=="false")
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine("Enter a valid value!");
            }*/


            //Excercise 2-multiple of 100

            /*Console.WriteLine("Enter a number");
            string userInput = Console.ReadLine();
            int userInputValue;

            if(!int.TryParse(userInput,out userInputValue))
            {
                Console.WriteLine("Can't you read? Enter a number not anything else!");
            } else if(userInputValue%100==0)
            {
                Console.WriteLine("You have entered a cool number!");
            } else
            {
                Console.WriteLine("The number you've entered is not cool at all!");
            }*/


            //Excercise 3- Return name of month

           /* Console.WriteLine("Enter a number from 1 to 12");
            string userInput = Console.ReadLine();
            int userInputValue;
            if (!int.TryParse(userInput, out userInputValue) || userInputValue > 12 || userInputValue < 1)
            {
                Console.WriteLine("Error! Incorrect value!");
            }
            else
            {
                switch (userInputValue)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                    default:
                        break;
                }
            }*/
                    // Excercise 4-Profitable gamble

                    /*Console.WriteLine("Enter the probability");
                      int userProbability = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("Enter the prize");
                      int userPrize = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("Enter the cost of paying");
                      int userCost = Convert.ToInt32(Console.ReadLine());
                      if (userProbability*userPrize>userCost) {
                            Console.WriteLine("You won!");
                        } else
                        {
                            Console.WriteLine("You loose!"!);
                        }*/


                        //Excercise 5-The farm problem
                        /*int chicken = 2 ;
                        int cows = 4;
                        int pigs = 4;

                        Console.WriteLine("Enter the number of chickens");
                        int inputChickens = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number of cows");
                        int inputCows = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number of pigs");
                        int inputPigs = Convert.ToInt32(Console.ReadLine());

                        int chickensResult = chicken * inputChickens;
                        int cowsResult = cows * inputCows;
                        int pigsResult = pigs * inputPigs;
                        int totalNumberOfLegs = chickensResult + cowsResult + pigsResult;
                        Console.WriteLine($"The total number of animal legs on your farm is {totalNumberOfLegs}.");*/


                        //Excercise 6-Word count

                        /*Console.WriteLine("Enter a sentence:");
                        string sentence = Console.ReadLine();
                        int wordCount = sentence.Split(' ').Length;

                        Console.WriteLine($"The number of words is {wordCount}.");*/


                        //Excercise 7-Liquor store
                        /*Console.WriteLine("Hello please enter your name.");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Now enter your last name.");
                        string userLastName = Console.ReadLine();
                        Console.WriteLine("Now enter your age please.");
                        string userAge = Console.ReadLine();
                        int userAgeValue;
                        if (!int.TryParse(userAge, out userAgeValue))
                        {
                            Console.WriteLine("Please enter a valid age.");
                        } else if (userAgeValue>=18)
                        {
                            Console.WriteLine("Enter what kind of drink you want.");
                            string userDrink = Console.ReadLine();
                            Console.WriteLine($"Dear {userName} {userLastName} here you are a bottle of {userDrink} , have a nice day.");
                        } else
                        {
                            Console.WriteLine($"Dear {userName} {userLastName} I am sorry but you are not allowed to buy alcohol.");
                        }*/


                        //Excercise 8-Coffee machine

                        /* Console.WriteLine("Welcome dear customer! Please select a drink:");
                         Console.WriteLine("1. Espresso............2$");
                         Console.WriteLine("2. Macchiato..........3.5$");
                         Console.WriteLine("3. Latte..............4$");
                         Console.WriteLine("4. Cappuccino..........6$");
                         Console.WriteLine("5. Tea................1.5$");

                         double espressoPrice = 2;
                         double macchiatoPrice = 3.5;
                         double lattePrice = 4;
                         double cappuccinoPrice = 6;
                         double teaPrice = 1.5;

                         Console.WriteLine("Enter the number of the drink you want:");

                         int userInputNumber = int.Parse(Console.ReadLine());
                         Console.WriteLine("Please choose the sweetness level from 1-5");
                         int userInputSweetness = int.Parse(Console.ReadLine());

                          if (userInputNumber == 1)
                         {
                             Console.WriteLine($"You chose espresso with the sweetness level of {userInputSweetness} please enter {espressoPrice} dollars");

                             double userInputDollars = double.Parse(Console.ReadLine());
                             if (userInputDollars < espressoPrice)
                             {
                                 Console.WriteLine("You don't have enough money, you need {0}", espressoPrice - userInputDollars + " dollar more.");
                             }
                             else if (userInputDollars == espressoPrice)
                             {
                                 Console.WriteLine("Here's your coffee, enjoy!");
                             }
                             else if (userInputDollars > espressoPrice)
                             {
                                 Console.WriteLine("Here's your change of {0}:", userInputDollars - espressoPrice + " dollars enjoy your coffee!");
                             }
                         }
                         else if (userInputNumber == 2)
                         {
                             Console.WriteLine($"You chose macchiato with the sweetness level of {userInputSweetness} please enter {macchiatoPrice} dollars.");
                             double userInputDollars = double.Parse(Console.ReadLine());
                             if (userInputDollars < macchiatoPrice)
                             {
                                 Console.WriteLine("You don't have enough money,you need {0}", macchiatoPrice - userInputDollars + " dollar more.");
                             }
                             else if (userInputDollars == macchiatoPrice)
                             {
                                 Console.WriteLine("Here's your coffee, enjoy!");
                             }
                             else if (userInputDollars > macchiatoPrice)
                             {
                                 Console.WriteLine("Here's your change of {0}", userInputDollars - macchiatoPrice + " dollars, enjoy your coffee!");
                             }
                         }
                         else if (userInputNumber == 3)
                         {
                             Console.WriteLine($"You chose latte with the sweetness level of {userInputSweetness} please enter {lattePrice} dollars.");
                             double userInputDollars = double.Parse(Console.ReadLine());
                             if (userInputDollars < lattePrice)
                             {
                                 Console.WriteLine("You don't have enough money, you need {0}", lattePrice - userInputDollars + " dollar more.");
                             }
                             else if (userInputDollars == lattePrice)
                             {
                                 Console.WriteLine("Here's your coffee, enjoy");
                             }
                             else if (userInputDollars > lattePrice)
                             {
                                 Console.WriteLine("Here's your change of {0}", userInputDollars - lattePrice + " dollars, enjoy your coffee!");
                             }
                         }
                         else if (userInputNumber == 4)
                         {
                             Console.WriteLine($"You chose cappuccino with the sweetness level of {userInputSweetness} please enter {cappuccinoPrice} dollars.");
                             double userInputDollars = double.Parse(Console.ReadLine());
                             if (userInputDollars < cappuccinoPrice)
                             {
                                 Console.WriteLine("You don't have enough money, you need {0}", cappuccinoPrice - userInputDollars + " dollar more.");
                             }
                             else if (userInputDollars == cappuccinoPrice)
                             {
                                 Console.WriteLine("Here's your coffee, enjoy!");
                             }
                             else if (userInputDollars > cappuccinoPrice)
                             {
                                 Console.WriteLine("Here's your change of {0}", userInputDollars - lattePrice + " dollars, enjoy your coffee!");
                             }
                         }
                         else if (userInputNumber == 5)
                         {
                             Console.WriteLine($"You chose tea with the sweetness level of {userInputSweetness} please enter {teaPrice} dollars.");
                             double userInputDollars = double.Parse(Console.ReadLine());
                             if (userInputDollars < teaPrice)
                             {
                                 Console.WriteLine("You don't have enough money, you need {0}", teaPrice - userInputDollars + " dollars more.");
                             }
                             else if (userInputDollars == teaPrice)
                             {
                                 Console.WriteLine("Here's your coffee, enjoy!");
                             }
                             else if (userInputDollars > teaPrice)
                             {
                                 Console.WriteLine("Here's your change of {0}", userInputDollars - teaPrice + " dollars, enjoy your coffee!");
                             }
                         }*/


                        //Excercise 9- Future prediction

                        //So ovaa ne se snajdov :')


                        //Excercise 10-Farenheit to Celsius conversion

                        /*Console.WriteLine("Enter how many celsius degrees you wish to convert:");
                        int userInput = Convert.ToInt32(Console.ReadLine());
                        int kelvin = userInput + 273;
                        int farenheit = userInput * 18 / 10 + 32;
                        Console.WriteLine($"{userInput} celsius degrees is equal to {kelvin} kelvin and {farenheit} farenheit degrees.");*/



                  Console.ReadLine();



            
            
        }
    }
}



