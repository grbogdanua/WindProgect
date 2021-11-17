using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
	public class Human
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public Address HumanAddress { get; set; }
		public string ImageAddress { get; set; }

		public Human(string name, string surname, int age, Address address)
		{
			Name = name;
			Surname = surname;
			Age = age;
			HumanAddress = address;
		}
		public Human()
		{
			/*Console.Write("Name: ");
			Name = Console.ReadLine();

			Console.Write("Surname: ");
			Surname = Console.ReadLine();

			Console.Write("Age: ");
			var enteredAge = Console.ReadLine();
			int num;
			while (!int.TryParse(enteredAge, out num))
			{
				Console.Write("Age isn`t number. Try again. Age: ");
				enteredAge = Console.ReadLine();
			}
			Age = num;

			Console.WriteLine("Address:");
			HumanAddress = new Address();*/
		}
		/*public void GetInfo()
		{
			Console.WriteLine($"Name: {Name} Sername: {Surname} Age: {Age}");
			Console.WriteLine("Address: ");
			HumanAddress.GetInfo();
		}*/
		public static bool operator <(Human humanA, Human humanB)
		{
			return ((humanA.Surname.CompareTo(humanB.Surname)) < 0);
		}
		public static bool operator >(Human humanA, Human humanB)
		{
			return ((humanA.Surname.CompareTo(humanB.Surname)) > 0);
		}
	}
}
