using System;

namespace AWholeNewWorld
{
    class Program
    {

       

        public static string guessIt(int lower, int upper)
        {
             int guess=(lower+upper)/2;
              Console.WriteLine("Is your number: "+guess + "?, yes or no.");
            string yesOrNo=Console.ReadLine();
            return yesOrNo;  
        }
        static void Main(string[] args)
        {
            int numberOfGuesses=1;
            int guess=50;
            int upper=100;
            int lower=1;
            Console.WriteLine("Guess the Number!");
            Console.WriteLine("Choose a number from 1 to 100");
            Console.WriteLine("Is your number " + guess + "?, reply yes or no.");
            string yesOrNo=Console.ReadLine();
            if (yesOrNo=="yes")
            {
                Console.WriteLine("The number of guesses was: "+ numberOfGuesses);
            }
            else
            {
                while(yesOrNo =="no")
                {
                Console.WriteLine("Is your number higher or lower?");
                string highOrLow=Console.ReadLine();
                if (highOrLow=="higher")
                {
                    lower=guess+1;
                    yesOrNo=guessIt(lower,upper);
                    numberOfGuesses+=1;
                    if (yesOrNo=="yes")
                    {
                        Console.WriteLine("The number of guesses was: " + numberOfGuesses);
                    } else 
                    {
                        guess=(lower+upper)/2;
                    }
                }
                if (highOrLow=="lower")
                {
                    upper=guess-1;
                 yesOrNo=guessIt(lower,upper);
                 numberOfGuesses+=1;
                 if (yesOrNo=="yes")
                {
                     Console.WriteLine("The number of guesses was: " + numberOfGuesses);
                } else {
                   guess=(lower+upper)/2; 
                }
                }
                }

            }


        }
    }
}
