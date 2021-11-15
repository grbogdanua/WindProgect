using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{

	public class Teacher : Human
	{ 


		public List<Student> Students { get; private set; }

		public Teacher(string name, string surname, int age, Address address)
		{
			Name = name;
			Surname = surname;
			Age = age;
			HumanAddress = address;
			Students = new List<Student> { };
		}
		public Teacher(string surname)
		{
			Surname = surname;
		}
		public Teacher()
		{
			Students = new List<Student> { };
		}
		public void AddStudent(Student student)
		{
			Students.Add(student);
		}
		public void AddStudent()
		{
			Students.Add(new Student());
		}
		public void SerchStudent(string surname)
		{
			foreach (Student student in Students)
			{
				if (student.Surname == surname)
				{
					//student.Getinfo();
				}
			}
		}
		/*public void ModifyStudent(string surname)
		{
			foreach (Student student in Students)
			{
				if (student.Surname == surname)
				{
					student.ModifyStudent();
				}
			}
		}
		public void Getinfo()
		{
			Console.WriteLine("Teacher:");
			GetInfo();
			Console.WriteLine("Students: ");
			foreach (Student student in Students)
			{
				Console.WriteLine("\n");
				student.Getinfo();
			}
		}
		public void WorkWith()
		{
			bool cycle = true;
			while (cycle)
			{
				Console.WriteLine("1 <- add student\n2 <- serch student\n3 <- Modify student\n4 <- Chenge Teacher`s address\n5 <- Stop");
				var enterednumber = Console.ReadLine();
				switch (enterednumber)
				{
					case "1":
						AddStudent();
						break;
					case "2":
						Console.Write("Students Sername please: ");
						SerchStudent(Console.ReadLine());
						break;
					case "3":
						Console.Write("Students Sername please: ");
						ModifyStudent(Console.ReadLine());
						break;
					case "4":
						HumanAddress = new Address();
						break;
					case "5":
						cycle = false;
						break;
					default:
						Console.WriteLine("You write something wrong");
						break;
				}
			}*/
	}
}

