using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
	class Randomizer
	{
		private List<string> name = new List<string>() { "Bob", "Mary", "Frank", "Anton" };
		private List<string> surname = new List<string>() { "Sunon", "Teari", "Gorison", "Horisan" };
		private List<string> country = new List<string>() { "Ukrain", "Poland" };
		private List<string> district = new List<string>() { "Kherson", "Odesa", "Kiev" };
		private List<string> city = new List<string>() { "Kherson", "Odesa", "Kiev" };
		private List<string> street = new List<string>() { "Antipenko", "Kosatskiy", "Pokrisheva" };

		public string Name()
		{
			Random nameIndex = new Random();
			return (name[nameIndex.Next(name.Count())]);
		}
		public string Surname()
		{
			Random surnameIndex = new Random();
			return (surname[surnameIndex.Next(surname.Count())]);
		}
		public string Age()
		{
			Random age = new Random();
			return Convert.ToString(age.Next(18, 90));
		}
		public string Country()
		{
			Random countryIndex = new Random();
			return (country[countryIndex.Next(country.Count())]);
		}
		public string District()
		{
			Random districtIndex = new Random();
			return (district[districtIndex.Next(district.Count())]);
		}
		public string City()
		{
			Random cityIndex = new Random();
			return (city[cityIndex.Next(city.Count())]);
		}
		public string Street()
		{
			Random streetIndex = new Random();
			return (street[streetIndex.Next(street.Count())]);
		}
		public string Housenumber()
		{
			Random housenumber = new Random();
			return Convert.ToString(housenumber.Next(1, 200));
		}
		public void LoadLists()
		{

		}
	}
}
