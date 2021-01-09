using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise1
{
	class Student: Person
	{
		private float gpa;
		public float Gpa { get => gpa; set => gpa = value; }

		public Student()
		{
		}

		public override void DisplayPerson()
		{
			Console.WriteLine($"Student is:\n + {base.Name}\n + {base.Age}\n + {gpa}");
		}

	}

}
