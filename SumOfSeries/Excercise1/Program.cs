using System;

namespace Excercise1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Student student = new Student();
			student.Age = int.Parse(Console.ReadLine());
			student.Name = Console.ReadLine();
			student.Gpa = float.Parse(Console.ReadLine());
			student.DisplayPerson();
		}
	}
}
