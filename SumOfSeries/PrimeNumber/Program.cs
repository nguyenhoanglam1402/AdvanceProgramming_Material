using System;

namespace PrimeNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number");
			int number = int.Parse(Console.ReadLine());
			string result = (CheckPrimeNumber(number)) ? "This the the prime number" : "This is not a prime number";
			Console.WriteLine(result);
		}

		static bool CheckPrimeNumber(int number)
		{
			int temp = number / 2;
			for(int count = 2; count <= temp; count++)
			{
				if (number % count == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
