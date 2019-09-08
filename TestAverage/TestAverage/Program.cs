using System;
using System.Linq;
namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many scores do you have?");

            
            int ScoreNumber = int.Parse(Console.ReadLine());
            if(ScoreNumber == 0)
            {
                Console.WriteLine("Blame Billy as he never scores.");
            }
            else
            {
                int[] ScoreGroup = new int[ScoreNumber];

                for (int i = 0; i < ScoreNumber; i++)
                {
                    Console.WriteLine("What is score number " + (i + 1) + " ?");
                    ScoreGroup[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Your avg is " + ScoreGroup.Average() + ".");


            }
        }    
    }
}