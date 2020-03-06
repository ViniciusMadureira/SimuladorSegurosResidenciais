using System.IO;

namespace Classes
{
	public class Estado
	{
		private string name;
		private char[] acronym;

		public Estado getState()
		{
			string[] lineOfContents = File.ReadAllLines("states.txt");
			foreach (var line in lineOfContents)
			{
				string[] tokens = line.Split(',');
				//comboBox1.Items.Add(tokens[0]);
			}
			return null;
		}


	}

}

