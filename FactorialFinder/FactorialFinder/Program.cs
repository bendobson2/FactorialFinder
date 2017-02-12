/*This program will allow the user to input any integer value greater than one, 
 * and will output all factors, and if it is a prime number, it will specify that.*/

using System;

class FactorialFinder
{
    static void Main()
    {
        bool goAgain = true;
        Console.WriteLine("Welcome to the program!");
        while (goAgain == true) //In case the user wants to do more than one number.
        {
            int inputtedNum = 5;
            Console.WriteLine("Please input any integer value above one.");
            inputtedNum = Int32.Parse(Console.ReadLine()); //inputting the # 
            while (inputtedNum < 2) //making sure the inputted # is valid.
            {
                Console.WriteLine("That number is invalid. Please input a valid number that is at least one.");
                inputtedNum = Int32.Parse(Console.ReadLine()); //inputs an integer value to find the factors for it
            }
            string finalOutput = ("The factors for " + inputtedNum + " are " + "1, ");//The string that will be outputted withall the factors
            int counter = 2;
            bool ifFactor = false; //starts as false, will only turn true if there is at least one factor. Otherwise it assumes it's a prime number
            while (counter < inputtedNum) //As long as the denominator is less than the inputted number. 
            {
                if ((inputtedNum % counter) == 0) //seeing if the number is a factor or not. 
                {
                    finalOutput += (counter + ", "); //adding the factor to the string
                    ifFactor = true;
                }
                counter += 1; //making the while loop work
            }

            if (ifFactor == true)
            {
                Console.WriteLine(finalOutput + "and " + inputtedNum + ", of course."); //outputting the string
            }
            else Console.WriteLine("The number you inputted is actually a prime number, as the only factors are 1 and " + inputtedNum + "! Wow!");


            int ans = 0;
            bool verifyError = true; //to make sure there are no errors

            while (verifyError == true) //As long as the integer is invalid, this loop will continue. 
            {
                Console.WriteLine("Would you like to use the program again? (1 = yes, 2 = no)");//in case the user wants to go again
                ans = Int32.Parse(Console.ReadLine());//inputting the number, which will affect the 'goAgain' bool
                if (ans == 1) verifyError = false; //If the input is valid, then it changes
                    else if (ans == 2) verifyError = false; //checking to see if input is valid
                        else Console.Write("Error, invalid input. "); //If neither of the above options are true, then it tells you to try again
            }

            if (ans == 2)//to see if the user wants to quit
            {
                goAgain = false; //makes the 'goAgain' while loop not work anymore
            }
        }
        Console.WriteLine("Thanks for using the program! Press any key to exit:");//thanking the user for using the program. 
        Console.ReadKey();//my computer is dumb and doesnt let me see what happened before the command prompt closes. Just means that the user has to press a key to exit
    }
}