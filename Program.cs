using System;

namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            // Part 1
            // Get an input number from the console
            // Print all numbers from 1 to that number
            // Get another input number from the console
            // Print all numbers from that number to 1

            Console.WriteLine("Please input a number:");

            int input = 1;

            bool parseNumber = int.TryParse(Console.ReadLine(), out input);

            for (int i = 1; i <= input; i++)


                Console.WriteLine(i);


            Console.WriteLine("Please input another number");

            int anotherInput;

            bool parseAnotherNumber = int.TryParse(Console.ReadLine(), out anotherInput);

            for (int i = anotherInput; i >= 1; i--)

                Console.WriteLine(i);




            Console.ReadLine();

            #endregion

            #region

            // Part 2
            //Get an input number from the console
            //Print all even numbers starting from 2
            //Get another input number from the console
            //Print all odd numbers starting from 1

            Console.WriteLine("Please input a number:");

            int inputEven;

            bool parseEvenNumber = int.TryParse(Console.ReadLine(), out inputEven);
            for (int i = 2; i <= inputEven; i++)

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }

            Console.WriteLine("Please input a number:");

            int inputOdd;

            bool parseOddNumber = int.TryParse(Console.ReadLine(), out inputOdd);
            for (int i = 2; i <= inputOdd; i++)

                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            Console.ReadLine();

            #endregion

            #region

            //Part 3
            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N
            //Print all the names after user enters N
            //Hint: we need to use endless loop until user enter N, then we want to "break" the loop


            string[] arr = new string[] { };
            var index = 0;
            string answer;
            string Newname;

            while (true)
            {
                Console.WriteLine("Do you want to enter a name? Y or N ");
                answer = Console.ReadLine();

                if (answer.ToUpper() == "Y")
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    Console.WriteLine("Please enter a name ");
                    Newname = Console.ReadLine();
                    arr[index] = Newname;
                    index++;
                    continue;
                }
                else if (answer.ToUpper() == "N")
                {
                    foreach (string name in arr)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                }
                
            }
            Console.ReadLine();

            #endregion


        }
    }
}
