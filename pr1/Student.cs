using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{ 
	[Serializable]

	public class Student : Human
	{
		public Mark Grade { get; set; }
		public Student(string name, string surname, int age, string imageAddress, Address address, Mark mark)
		{
			Name = name;
			Surname = surname;
			Age = age;
			ImageAddress = imageAddress;
			HumanAddress = address;
			Grade = mark;
		}
		public Student(string surname)
		{
			Surname = surname;
		}
		public Student()
		{
			Grade = new Mark();
		}
		/*private int GenerateAge()
		{
			Console.Write("Age: ");
			var enteredAge = Console.ReadLine();
			int num;
			while (!int.TryParse(enteredAge, out num))
			{
				Console.Write("Age isn`t number. Try again. Age: ");
				enteredAge = Console.ReadLine();
			}
			return (num);
		}
		public void ModifyStudent()
		{
			bool cycle = true;
			while (cycle)
			{
				Console.WriteLine("1 <- New Marks\n2 <- Change Address\n3 <- Change age\n4 <- return");
				var entered = Console.ReadLine();
				switch (entered)
				{
					case "1":
						Grade = new Mark();
						break;
					case "2":
						HumanAddress = new Address();
						break;
					case "3":
						Age = GenerateAge();
						break;
					case "4":
						cycle = false;
						break;
					default:
						Console.WriteLine("You wrote something wrong");
						break;
				}
			}
		}
		public void Getinfo()
		{
			GetInfo();
			Grade.GetInfo();
		}*/
	}
}

