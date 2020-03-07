using System.Configuration;

namespace Classes
{
	public class City
	{
		private string name;
		private double individualIndex;
		
		public City(string name, double individualIndex)
		{
			setName(name);
			setIndividualIndex(individualIndex);
		}

		private void setName(string name)
		{
			if (name.Length >= 2 && name.Length <= 30)
			{
				this.name = name;
			}
		}
		
		public string getName()
		{
			return name;
		}

		private void setIndividualIndex(double individualIndex)
		{
			if (individualIndex >= 0.0)
			{
				this.individualIndex = individualIndex;
			}
		}

		public double getIndividualIndex()
		{
			return individualIndex;
		}
	}
}

