using System;
using System.Collections.Generic;
using System.Text;

namespace StudentList
{
	class Student
	{
		private string name;
		private int age;
		private float gpa;

		public string Name { get => Name; set => Name = value; }
		public float Gpa { get => gpa; set => gpa = value; }
		public int Age { get => age; set => age = value; }

		public Student(string name)
		{
			Name = name;
		}

		//public void SetName(string name) { Name1 = name; }
		//public string GetName() { return Name1; }

		//public void SetAge(int age) { Age = age; }
		//public int GetAge() { return Age; }

		//public void SetGPA(float gpa) { GPA = gpa; }
		//public float GetGPA() { return GPA; }
	}
}
