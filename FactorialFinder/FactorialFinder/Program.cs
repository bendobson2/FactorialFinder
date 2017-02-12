using System;

class FactorialFinder
{
    static void Main()
    {
        Console.WriteLine("ayyyy lmaooooololol");
        Console.WriteLine("Please input any integer value above one.");
        int inputtedNum = Int32.Parse(Console.ReadLine()); //inputting the # 
        while (inputtedNum < 1) //making sure the inputted # is valid.
        {
            Console.WriteLine("That number is invalid. Please input a valid number that is at least one.");
            inputtedNum = Int32.Parse(Console.ReadLine());
        }
        string finalOutput = ("The factors for " + inputtedNum + " are ");//The string that will be outputted withall the factors
        int counter = 2;
        bool tvf = false;
        while (counter < inputtedNum)
        {
            if ((inputtedNum % counter) == 0) //seeing if the number is a factor or not. 
            {
                finalOutput += (counter + " "); //adding the factor to the string
                tvf = true;
            }
            counter += 1; //making the while loop work
        }
        if (tvf == true)
        {
            Console.WriteLine(finalOutput + ".");
        }
        else Console.WriteLine("The number you inputted is actually a prime number! Congrats! Wow!");
        Console.ReadKey();//to make sure i can actually see the output. my cmd is dumb and closes too soon
    }
}