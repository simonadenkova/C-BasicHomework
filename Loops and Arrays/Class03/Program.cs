using System;

namespace Class03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise 1

           /* string[] G1 = new string[5]
            {
                  "Petko",
                  "Stanko",
                  "Darko",
                  "Vlatko",
                  "Boris"
            };


            string[] G2 = new string[5]
            {
                  "Lauren",
                  "Camila",
                  "Normani",
                  "Dinah",
                  "Ally"
            };

            Console.WriteLine("Enter the number 1 or 2");
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < G1.Length; i++)

            {
                if (userInput == 1)
                {

                    Console.WriteLine($"The students in G1 are: {G1[i]}");

                }
                
            }
            for (int i = 0; i < G2.Length; i++)

            {
                if (userInput == 2)
                {
                    Console.WriteLine($"The students in G2 are: {G2[i]} ");
                }
            }*/


            //Excercise 2

            /*int sum = 0;
            
            int[] numArray = new int[6]; 

            for (int i = 0; i <6; i++)
            {
                Console.WriteLine("Enter your number:");
                
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"You entered the number: {numArray[i]}");
            }


            for (int i = 0; i < 6; i++)

            {
                if (numArray[i] % 2 == 0)
                {
                    sum += numArray[i];
                }


            }

            Console.WriteLine($"The sum of all even numbers stored in the array is : {sum}.");*/


            //Excercise 3

            /* string[] trainerArray = new string[3]
             {
                 "Martin",
                 "Ivo",
                 "Dejan"
             };

             string[] g1Array = new string[5]
             {
                 "Megan",
                 "Ryan",
                 "Emma",
                 "Jennifer",
                 "Alicia"
             };

             string[] g2Array = new string[5]
             {
                 "Simona",
                 "Lauren",
                 "Dinah",
                 "Ally",
                 "Normani"
             };

             string[] g3Array = new string[5] 
             {   "Mike", 
                 "John", 
                 "Peter", 
                "Anastasia",
                 "Jack"
             };

             string[] subjectsArray = new string[]
             {
                 "Javascript",
                 "C#",
                 "HTML",
                 "CSS"
             };

              Console.WriteLine("Hello please tell us if you are a trainer or a student.");
             string userInput = Console.ReadLine();
             Console.WriteLine("Can you now please tell us your name.");
             string userNameInput = Console.ReadLine();
             string value = userNameInput;
             int findTrainer = Array.IndexOf(trainerArray, value);
             int firstGroupStudent = Array.IndexOf(g1Array,value);
             int secondGroupStudent = Array.IndexOf(g2Array, value);
             int thirdGroupStudent = Array.IndexOf(g3Array, value);
             if(findTrainer>-1)
             {
                 for (int i =0;i<g1Array.Length;i++)
                 {
                     {
                         for(i =0;i<g2Array.Length;i++)
                         {
                             for(i=0;i<g3Array.Length;i++)
                             {
                                 Console.WriteLine($" Hello {userNameInput}, here are your students: {g1Array[i]}, {g2Array[i]}, {g3Array[i]}  " );
                             }
                         }
                     }
                 }
                 Console.WriteLine("Enter your announcement!");
                 string trainerAnnoucementInput = Console.ReadLine();
             } else if (firstGroupStudent>-1 || secondGroupStudent > -1 || thirdGroupStudent >-1)
             {
                 for(int i = 0;i < subjectsArray.Length;i++)
                 {
                     Console.WriteLine($" Hello {userNameInput}, here are your subjects: {subjectsArray[i]} ");
                 }

             }*/



          //Jas ne znam dali nemam vnimavano ubavo na chasovi ama stvarno ne znam kako da ne mi se povtoruva sto pati istoto koga koristam Console.Writeline
           

            Console.ReadLine();
        }
    }
}
