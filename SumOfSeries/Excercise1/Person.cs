using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise1
{
	class Person
	{
		private int age;
		private string name;
		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }

		public Person(string name)
		{
			this.name = name;
		}

		public Person()
		{

		}

		public virtual void DisplayPerson()
		{
			Console.WriteLine($"Name of target : {name}\nAge of target : {age}");
		}
	}
}
