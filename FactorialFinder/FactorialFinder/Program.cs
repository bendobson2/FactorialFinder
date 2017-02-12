using System;

class FactorialFinder
{
    static void Main()
    {
        Console.WriteLine("Please input any integer value above one.");
        int inputtedNum = Int32.Parse(Console.ReadLine()); //inputting the # 
        while (inputtedNum < 1) //making sure the inputted # is valid.
        {
            Console.WriteLine("That number is invalid. Please input a valid number that is at least one.");
            inputtedNum = Int32.Parse(Console.ReadLine()); //inputs an integer value to find the factors for it
        }
        string finalOutput = ("The factors for " + inputtedNum + " are " + "1, ");//The string that will be outputted withall the factors
        int counter = 2;
        bool tvf = false; //starts as false, will only turn true if there is at least one factor. Otherwise it assumes it's a prime number
        while (counter < inputtedNum) //As long as the denominator is less than the inputted number. 
        {
            if ((inputtedNum % counter) == 0) //seeing if the number is a factor or not. 
            {
                finalOutput += (counter + ", "); //adding the factor to the string
                tvf = true;
            }
            counter += 1; //making the while loop work
        }
        if (tvf == true)
        {
            Console.WriteLine(finalOutput + "and " + inputtedNum +", of course."); //outputting the string
        }
        else Console.WriteLine("The number you inputted is actually a prime number, as the only factors are 1 and " + inputtedNum + "! Wow!");
        Console.ReadKey();//to make sure i can actually see the output. my compiler closes before I can actually read the output
    }
}