using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
	public class Address
	{
		public string Country { get; set; }
		public string District { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public int Housenumber { get; set; }

		public Address()
		{
			Console.Write("Country: ");
			Country = Console.ReadLine();
			Console.Write("District: ");
			District = Console.ReadLine();
			Console.Write("City: ");
			City = Console.ReadLine();
			Console.Write("Street: ");
			Street = Console.ReadLine();
			Console.Write("House number: ");
			var enteredhousenumber = Console.ReadLine();
			int num;
			while (!int.TryParse(enteredhousenumber, out num))
			{
				Console.Write("Housenumber isn`t number. Try again. Housenumber: ");
				enteredhousenumber = Console.ReadLine();
			}
			Housenumber = num;
		}
		public Address(string newcountry, string newdistrict,string newcity,string newstreet,int newhousenumber)
		{
			Country = newcountry;
			District = newdistrict;
			City = newcity;
			Street = newstreet;
			Housenumber = newhousenumber;
		}
		/*public void GetInfo()
		{
			Console.WriteLine($"Country: {Country}, District: {District}, City: {City}, Street: {Street}, House number: {Housenumber}");
		}*/
	}
}
