using System;

namespace GuessNumberGame
{
	class Program
	{
		static void Main(string[] args)
		{
			int time = 0;
			Random randrom = new Random();
			int result = randrom.Next(1, 100);
			int guess = 0;
			do
			{
				Console.WriteLine("What number do you guess [1 - 100]?");
				guess = int.Parse(Console.ReadLine());
				if(guess < result)
				{
					Console.WriteLine("Your result is lesser than result");
				}
				else if(guess > result)
				{
					Console.WriteLine("Your result is greater than result");
				}
				time++;
			} while (guess!= result && time <=7);
			if (time > 7)
			{
				Console.WriteLine("You loss");
				Console.WriteLine("{0}", result);
			}
			else
			{
				Console.WriteLine("You win !");
			}
			
		}
	}
}
