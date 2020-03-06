using System.Collections.Generic;
using System.IO;

namespace Classes
{
	public class State
	{
		private string name;
		private char[] acronym;
		LinkedList<City> cities = new LinkedList<City>();

		public State(string name, char[] acronym)
		{
			setName(name);
			setAcronym(acronym);
		}

		private void setName(string name)
		{
			if (name.Length >= 2)
			{
				this.name = name;
			}
		}

		public string getName()
		{
			return name;
		}

		private void setAcronym(char[] acronym)
		{
			if (acronym.Length == 2)
			{
				this.acronym = acronym;
			}			
		}

		public char[] getAcronym()
		{
			return acronym;
		}

		public State getState()
		{
			return this;
		}

		public bool addCity(City newCity)
		{
			foreach (var city in cities)
			{
				if (city.getName() == newCity.getName() && city.getIndividualIndex() == newCity.getIndividualIndex()) 
				{
					return false;
				}
			}
			cities.AddLast(newCity);
			return true;
		}

		public LinkedList<City> getCities()
		{
			return cities;
		}

	}

}

