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

            Console.WriteLine("Please enter a starting number:");

            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter an ending number:");

            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("I am thinking of a number between " + start + " and " + end);

            int answer = num.Next(start, end); //.Next(start, end) taken from MSDN



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
