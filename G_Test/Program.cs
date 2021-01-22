using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new Random(); //Random function inspired from MSDN

            int tries = 1;

            Console.WriteLine("I am thinking of a number between 0 and 100");

            int answer = num.Next(101); //.Next(101) taken from MSDN



            while (tries != 0)
            {
                Console.WriteLine("Please enter your guess:");

                int guess = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 was taken from MSDN


                
                if(guess == answer)
                {
                    Console.WriteLine("Congratulations, you have guessed correctly, in " + tries + " tries!");

                    Console.ReadKey();

                    tries = 0;
                }



                else if (guess > answer)
                {
                    Console.WriteLine("Your guess was too high, try again!");

                    tries++;
                }



                else
                {
                    Console.WriteLine("Your guess was too low, try again!");

                    tries++;
                }
            }
        }
    }
}
