using System;

namespace SumOfSeries
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, Please enter the number");
			int number = int.Parse(Console.ReadLine());
			int result = SumOfSeries(number);
			Console.WriteLine("Result : " + result);
		}

		static public int SumOfSeries(int number)
		{
			int count = 0;
			int sum = 0;
			while (count <= number){
				sum += count;
				count++;
			}
			return sum;
		}
	}
}
